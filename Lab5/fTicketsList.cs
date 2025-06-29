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
    public partial class fTicketsList : Form
    {
        private ITicketService _ticketService;
        public fTicketsList(ITicketService ticketService)
        {
            InitializeComponent();

            this._ticketService = ticketService;

            LoadTickets();
        }

        private void LoadTickets()
        {
            ticketsListView.Items.Clear();
            var tickets = _ticketService.GetAllTickets();

            foreach (var ticket in tickets)
            {
                var listItem = new ListViewItem(ticket.TicketId.ToString());
                listItem.SubItems.Add(ticket.RouteId.ToString());
                listItem.SubItems.Add(ticket.PassengerName);
                listItem.SubItems.Add(ticket.Bus);
                listItem.SubItems.Add(ticket.DepartureTime.ToString());
                listItem.SubItems.Add(ticket.Destination);
                listItem.SubItems.Add(ticket.DriverName);
                listItem.SubItems.Add(ticket.GetPrice().ToString("C"));

                ticketsListView.Items.Add(listItem);
            }
        }

        private void btnReturnTicket_Click(object sender, EventArgs e)
        {
            if (ticketsListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Виберіть квиток");
                return;
            }

            var selectedItem = ticketsListView.SelectedItems[0];
            int ticketid = int.Parse(selectedItem.SubItems[0].Text);
            _ticketService.ReturnTicket(ticketid);
            LoadTickets();
        }
    }
}
