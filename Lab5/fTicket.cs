using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketsLib;


namespace Lab5
{
    public partial class fTicket : Form
    {
        private ITicketService _ticketService;
        private Ticket _existingticket;
        private int _routeID;
        private string _destination;
        private string _bus;
        private string _driverName;

        public fTicket(ITicketService ticketService, int routeID, string destination, string bus, string DriverName)
        {
            InitializeComponent();
            this._routeID = routeID;
            this._ticketService = ticketService;
            this._destination = destination;
            this._bus = bus;
            this._driverName = DriverName;

            tbDestination.Text = destination;
            tbRouteID.Text = routeID.ToString();
            tbDriverName.Text = DriverName;
            tbBus.Text = bus;
        }
        public fTicket(ITicketService ticketService, Ticket existingticket = null)
        {
            InitializeComponent();
            this._ticketService = ticketService;
            this._existingticket = existingticket;

            if (existingticket != null)
            {
                tbRouteID.Text = existingticket.RouteId.ToString();
                labl124.Text = existingticket.PassengerName;
                tbDestination.Text = existingticket.Destination;
                tbRouteID.Enabled = false;
                tbDestination.Enabled = false;
            }
        }
       private void btnCreate_Click(object sender, EventArgs e)
       {
            string PassengerName = tbPassengerName.Text.Trim();
            
            if (string.IsNullOrEmpty(PassengerName))
            {
                MessageBox.Show("Введіть імя пассажира");
                return;
            }

            Type ticketType = null;
            string selectedTicketType = cmbTicketType.SelectedItem.ToString();
            if (selectedTicketType == "Standart Ticket")
            {
                ticketType = typeof(StandartTicket);
            }
            else if (selectedTicketType == "Discount Ticket")
            {
                ticketType = typeof(DiscountTicket);
            }
            else
            {
                MessageBox.Show("Invalid ticket type");
            }
            
                Ticket ticket = _ticketService.BuyTicket(_routeID, PassengerName, _destination, ticketType, _driverName, _bus);

            if (ticket != null)
            {
                MessageBox.Show($"Ви створили квиток успішно. ID квитка:{ticket.TicketId}");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Відбулась помилка. Повторіть спробу");
                this.DialogResult = DialogResult.None;
            }

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void fPhone_Load(object sender, EventArgs e)
        {
            

        }  
    }
}
