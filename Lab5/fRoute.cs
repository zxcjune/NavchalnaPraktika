using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RouteLib;
using TicketsLib;

namespace Lab5
{
    public partial class fRoute : Form
    {
        private readonly IRouteService _routeService;
        public Route NewRoute { get; set; }
        public fRoute(IRouteService routeService)
        {
            InitializeComponent();
            this._routeService = routeService;
            tbRouteNumber.Text = _routeService.GetNextRouteNumber().ToString();
            tbRouteNumber.Enabled = false;
        }

        public fRoute(Route route)
        {
            InitializeComponent();

            if (route != null)
            {
                tbRouteNumber.Text = route.RouteNumber.ToString();
                tbFinalDestination.Text = route.FinalDestination;
                tbStartPoint.Text = route.StartPoint;
                tbBus.Text = route.Bus;
                tbAvailableSeats.Text = route.AvailableSeats.ToString();
                tbTotalSeats.Text = route.TotalSeats.ToString();
                tbDriverName.Text = route.DriverName;
                tbDepartureTime.Text = route.DepartureTime.ToString();
                tbArrivalTime.Text = route.ArrivalTime.ToString();
                tbIntermediatePoint.Text = string.Join(", ", route.IntermediatePoint);

                tbRouteNumber.Enabled = false;
            }
        }

        private void btnCreateRoute_Click(object sender, EventArgs e)
        {
            string finalDestination = tbFinalDestination.Text.Trim();
            DateTime departuretime;
            List<string> intermediatePoints = new List<string>();
            if (!DateTime.TryParse(tbDepartureTime.Text.Trim(), out departuretime))
            {
                MessageBox.Show("Введіть правильний час відправлення");
            }
            DateTime arrivaltime;
            if (!DateTime.TryParse(tbArrivalTime.Text.Trim(), out arrivaltime))
            {
                MessageBox.Show("Введіть правильний час прибуття");
            }
            if (arrivaltime < departuretime)
            {
                MessageBox.Show("Час прибуття повинен бути пізніше ніж час відправлення");
                return;
            }
            string intermediatePointsText = tbIntermediatePoint.Text.Trim();
            if (!string.IsNullOrEmpty(intermediatePointsText))
            {
                intermediatePoints = intermediatePointsText.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                                           .Select(point => point.Trim())
                                                           .ToList();
            }

            NewRoute = new Route
            {
                RouteNumber = int.Parse(tbRouteNumber.Text),
                FinalDestination = finalDestination,
                DepartureTime = departuretime,
                TotalSeats = int.Parse(tbTotalSeats.Text),
                AvailableSeats = int.Parse(tbAvailableSeats.Text),
                ArrivalTime = arrivaltime,
                Bus = tbBus.Text.Trim(),
                DriverName = tbDriverName.Text.Trim(),
                StartPoint = tbStartPoint.Text.Trim(),
                IntermediatePoint = intermediatePoints
            };
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
