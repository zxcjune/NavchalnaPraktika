using RouteLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketsLib;

namespace Lab5
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IRouteService routeService = new RouteService();
            ITicketService ticketService = new TicketService(routeService);
            Application.Run(new fMain(routeService));
        }
    }
}
