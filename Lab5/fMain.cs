using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab5;
using RouteLib;
using Newtonsoft.Json;
using System.CodeDom;
using TicketsLib;
using UtilsLib;
using PDFExporterCustom;

namespace Lab5
{
    public partial class fMain : Form
    {
        private readonly IRouteService _routeService;
        private readonly ITicketService _ticketService;
        private SortOrder sortOrder = SortOrder.None;
        private int sortColumn = -1;
        public fMain(IRouteService routeService)
        {
            InitializeComponent();


            this._routeService = routeService;
            _ticketService = TicketService.GetInstance(_routeService);

            InitializeRoutesListView();
            this.Controls.Add(routesListView);



            LoadData();
            LoadRoutes();
        }

        private void InitializeRoutesListView()
        {

        }
        private void fMain_Load(object sender, EventArgs e)
        {
            routesListView.Focus();
        }

        private void fMain_Resize(object sender, EventArgs e)
        {
            int buttonsSize = 9 * btnAdd.Width + 3 * toolStripSeparator1.Width + 30;
            btnExit.Margin = new Padding(Width - buttonsSize, 0, 0, 0);
        }

        private void btnBuyTicket_Click(object sender, EventArgs e)
        {
            if (routesListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Виберіть маршрут спочатку");
                return;
            }

            var selectedItem = routesListView.SelectedItems[0];
            int routeId = int.Parse(selectedItem.SubItems[0].Text);
            string destination = selectedItem.SubItems[2].Text;
            string bus = selectedItem.SubItems[8].Text;
            string driverName = selectedItem.SubItems[9].Text;

            fTicket ticketform = new fTicket(_ticketService, routeId, destination, bus, driverName);

            if (ticketform.ShowDialog() == DialogResult.OK)
            {
                LoadRoutes();
            }
        }

        public void btnFilter_Click(object sender, EventArgs e)
        {
            string selectedFilter = cmbFilterCriteria.SelectedItem.ToString();
            string filterCriteria = tbFilterCriteria.Text;
            List<Route> defaultroutes = _routeService.GetAllRoutes();
            List<Route> filteredRoutes = null;

            switch (selectedFilter)
            {
                case "За вільними місцями":
                    if (int.TryParse(filterCriteria, out int minSeats))
                    {
                        filteredRoutes = RouteComparisonsFiltration.FilterByAvailableSeats(defaultroutes, minSeats);
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid number for available seats.");
                        return;
                    }
                    break;
                case "За місцем прибуття":
                    filteredRoutes = RouteComparisonsFiltration.FilterByDestination(defaultroutes, filterCriteria);
                    break;
            }

            DisplayRoutes(filteredRoutes);
        }

        public void LoadRoutes()
        {
            routesListView.Items.Clear();
            foreach (var route in _routeService.GetAllRoutes())
            {
                var listViewItem = new ListViewItem(route.RouteNumber.ToString());
                listViewItem.SubItems.Add(route.StartPoint);
                listViewItem.SubItems.Add(route.FinalDestination);
                listViewItem.SubItems.Add(string.Join(", ", route.IntermediatePoint));
                listViewItem.SubItems.Add(route.DepartureTime.ToString());
                listViewItem.SubItems.Add(route.ArrivalTime.ToString());
                listViewItem.SubItems.Add(route.TotalSeats.ToString());
                listViewItem.SubItems.Add(route.AvailableSeats.ToString());
                listViewItem.SubItems.Add(route.Bus);
                listViewItem.SubItems.Add(route.DriverName);

                routesListView.Items.Add(listViewItem);
            }
        }

        public void routesListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == sortColumn)
            {
                sortOrder = sortOrder == SortOrder.Ascending ? SortOrder.Descending : SortOrder.Ascending;
            }
            else
            {
                sortOrder = SortOrder.Ascending;
                sortColumn = e.Column;
            }

            routesListView.ListViewItemSorter = new ListViewItemComparer(e.Column, sortOrder);
        }

        public void DisplayRoutes(List<Route> routes)
        {
            routesListView.Items.Clear();
            foreach (var route in routes)
            {
                var listItem = new ListViewItem(route.RouteNumber.ToString())
                {
                    SubItems =
                    {
                        route.StartPoint,
                        route.FinalDestination,
                        string.Join(", ", route.IntermediatePoint),
                        route.DepartureTime.ToString(),
                        route.ArrivalTime.ToString(),
                        route.Bus.ToString(),
                        route.DriverName.ToString(),
                        route.TotalSeats.ToString(),
                        route.AvailableSeats.ToString()
                    }
                };
                routesListView.Items.Add(listItem);
            }
        }
        public void LoadData()
        {
            if (File.Exists("routes.json"))
            {
                var routes = JsonConvert.DeserializeObject<List<Route>>(File.ReadAllText("routes.json"));
                _routeService.SetRoutes(routes);
            }

            if (File.Exists("tickets.json"))
            {
                var settings = new JsonSerializerSettings();
                settings.Converters.Add(new TicketJsonConverter());
                var tickets = JsonConvert.DeserializeObject<List<Ticket>>(File.ReadAllText("tickets.json"), settings);
                _ticketService.SetTickets(tickets);
            }
        }

        public void SaveData()
        {
            var routes = _routeService.GetAllRoutes();
            var routesJson = JsonConvert.SerializeObject(routes, Formatting.Indented);
            File.WriteAllText("routes.json", routesJson);

            var tickets = _ticketService.GetAllTickets();
            var settings = new JsonSerializerSettings();
            settings.Converters.Add(new TicketJsonConverter());
            var ticketsJson = JsonConvert.SerializeObject(tickets, Formatting.Indented, settings);
            File.WriteAllText("tickets.json", ticketsJson);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрити застосунок?", "Вихід з програми", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnSaveText_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void fMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveData();
        }

        private void btnRemoveFilter_Click(object sender, EventArgs e)
        {
            LoadRoutes();
        }

        private void btnFindNearestRoute_Click(object sender, EventArgs e)
        {
            DateTime currenttime = DateTime.Now;
            string selectedtown = tbFindNearestRoute.Text;
            List<Route> defaultroutes = _routeService.GetAllRoutes();
            Route route = _routeService.FindNearestRoute(selectedtown, currenttime);

            routesListView.Items.Clear();

            var listItem = new ListViewItem(route.RouteNumber.ToString())
            {
                SubItems =
                    {
                        route.StartPoint,
                        route.FinalDestination,
                        string.Join(", ", route.IntermediatePoint),
                        route.DepartureTime.ToString(),
                        route.ArrivalTime.ToString(),
                        route.TotalSeats.ToString(),
                        route.AvailableSeats.ToString(),
                        route.Bus.ToString(),
                        route.DriverName.ToString()
                    }
            };
            routesListView.Items.Add(listItem);
        }

        private void btnOpenTicketList_Click(object sender, EventArgs e)
        {
            var ticketListForm = new fTicketsList(_ticketService);
            ticketListForm.Show();
            SaveData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fRoute fRoute = new fRoute(_routeService);
            if (fRoute.ShowDialog() == DialogResult.OK)
            {
                Route newRoute = fRoute.NewRoute;
                if (newRoute != null)
                {
                    _routeService.AddRoute(newRoute);
                    LoadRoutes();
                }
                else
                {
                    MessageBox.Show("Route creation failed.");
                }
            }
        }

        private void btnDeleteRoute_Click(object sender, EventArgs e)
        {
            if (routesListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a route to delete.");
                return;
            }

            var selectedItem = routesListView.SelectedItems[0];
            int routeId = int.Parse(selectedItem.SubItems[0].Text);

            var confirmResult = MessageBox.Show("Are you sure you want to delete this route?",
                                                 "Confirm Delete",
                                                 MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                _routeService.DeleteRoute(routeId);
                LoadRoutes();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (routesListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a route to edit.");
                return;
            }

            var selectedItem = routesListView.SelectedItems[0];
            int routeId = int.Parse(selectedItem.SubItems[0].Text);
            string startpoint = selectedItem.SubItems[1].Text;
            string finalDestination = selectedItem.SubItems[2].Text;
            List<string> intermediatePoints = selectedItem.SubItems[3].Text.Split(',').ToList();
            DateTime departureTime = DateTime.Parse(selectedItem.SubItems[4].Text);
            DateTime arrivalTime = DateTime.Parse(selectedItem.SubItems[5].Text);
            int totalseats = int.Parse(selectedItem.SubItems[6].Text);
            int availableseats = int.Parse(selectedItem.SubItems[7].Text);
            string bus = selectedItem.SubItems[8].Text;
            string drivername = selectedItem.SubItems[9].Text;

            Route selectedRoute = new Route
            {
                RouteNumber = routeId,
                FinalDestination = finalDestination,
                DepartureTime = departureTime,
                ArrivalTime = arrivalTime,
                IntermediatePoint = intermediatePoints,
                StartPoint = startpoint,
                TotalSeats = totalseats,
                AvailableSeats = availableseats,
                Bus = bus,
                DriverName = drivername
            };

            fRoute editRouteForm = new fRoute(selectedRoute);
            if (editRouteForm.ShowDialog() == DialogResult.OK)
            {
                Route updatedRoute = editRouteForm.NewRoute;
                _routeService.UpdateRoute(updatedRoute);
                LoadRoutes();
            }
        }

        private void btnCreateManifest_Click(object sender, EventArgs e)
        {
            if (routesListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Виберіть маршрут спочатку");
            }

            var selectedItem = routesListView.SelectedItems[0];
            int routeId = int.Parse(selectedItem.SubItems[0].Text);

            Route route = _routeService.GetRouteByNumber(routeId);
            if (route == null)
            {
                MessageBox.Show("Маршрут не знайдений");
                return;
            }

            List<Ticket> tickets = _ticketService.GetTicketsByRouteID(routeId);
            
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            saveFileDialog.Title = "Зберегти посадкову відомість";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filepath = saveFileDialog.FileName;
                PDFExporter.ExportTicketsToPDF(tickets, filepath);
                MessageBox.Show("Посадкова відомість збережена успішно");
            }
        }

        private void btnLastTicket_Click(object sender, EventArgs e)
        {
            List<Ticket> tickets = _ticketService.GetAllTickets();
            if (tickets.Count == 0)
            {
                MessageBox.Show("Квитки недоступні");
            }

            Ticket lastTicket = _ticketService.GetLastTicket();

            MessageBox.Show($"Останній квиток:\n" +
                        $"Ticket ID: {lastTicket.TicketId}\n" +
                        $"Route ID: {lastTicket.RouteId}\n" +
                        $"Ім'я пасажира: {lastTicket.PassengerName}\n" +
                        $"Місце прибуття: {lastTicket.Destination}\n" +
                        $"Час відправлення: {lastTicket.DepartureTime}\n" +
                        $"Автобус: {lastTicket.Bus}\n" +
                        $"Ім'я водія: {lastTicket.DriverName}");
        }
    }
}
