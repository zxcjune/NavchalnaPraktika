using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using RouteLib;
using System.Runtime.Remoting;
using Lab5;

namespace TicketsLib
{
    public interface ITicketService
    {
        Ticket GetLastTicket();
        void SetTickets(List<Ticket> tickets);
        Ticket BuyTicket(int RouteID, string PassengerName, string Destination, Type type, string driverName, string bus);
        bool ReturnTicket(int ticketid);
        List<Ticket> GetAllTickets();
        List<Ticket> GetTicketsByRouteID(int RouteID);
    }

    public abstract class Ticket
    {
        public int TicketId { get; set; }
        public int RouteId { get; set; }
        public string PassengerName { get; set; }
        public string Destination { get; set; }
        public string Bus { get; set; }
        public string DriverName { get; set; }

        public DateTime DepartureTime { get; set; }

        protected Ticket(int ticketId, int routeId, string passengerName, string destination, DateTime departureTime, string driverName, string bus)
        {
            TicketId = ticketId;
            RouteId = routeId;
            PassengerName = passengerName;
            Destination = destination;
            DepartureTime = departureTime;
            DriverName = driverName;
            Bus = bus;
        }

        public Ticket()
        {
        }

        public abstract double GetPrice();
    }

    public class StandartTicket : Ticket
    {

        public override double GetPrice()
        {
            double price = 50.5;
            return price;
        }

        public StandartTicket(int ticketId, int routeId, string passengerName, string destination, DateTime departureTime, string driverName, string bus) 
            : base(ticketId, routeId, passengerName, destination, departureTime, driverName, bus)
        {
        }

        public StandartTicket()
        {

        }
    }



    public class DiscountTicket : Ticket
    {
        public override double GetPrice()
        {
            double price = 40;
            return price;
        }

        public DiscountTicket(int ticketId, int routeId, string passengerName, string destination, DateTime departureTime, string driverName, string bus)
            : base(ticketId, routeId, passengerName, destination, departureTime, driverName, bus)
        {
        }

        public DiscountTicket() { }
    }
    public class TicketService : ITicketService
    {
        private static TicketService _instance;
        private static readonly object _lock = new object();

        private List<Ticket> _tickets;

        private int _ticketId;

        private IRouteService _routeService;
        public TicketService(IRouteService routeService)
        {
            _tickets = new List<Ticket>();
            _ticketId = 1;
            this._routeService = routeService;
        }

        public static TicketService GetInstance(IRouteService routeService)
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new TicketService(routeService);
                    }
                }
            }
            return _instance;
        }

        public Ticket GetLastTicket()
        {
            if (_tickets.Count == 0)
            {
                return null;
            }

            return _tickets.Last();
        }
        public Ticket BuyTicket(int routeId, string passengerName, string destination, Type ticketType, string driverName, string bus)
        {
            Route route = _routeService.GetRouteByNumber(routeId);
            if (route == null || route.AvailableSeats <= 0 ||
                (route.FinalDestination != destination && !route.IntermediatePoint.Contains(destination)))
            {
                return null;
            }

            Ticket ticket;
            if (ticketType == typeof(StandartTicket))
            {
                ticket = new StandartTicket(_ticketId, routeId, passengerName, destination, route.DepartureTime, driverName, bus);
            }
            else if (ticketType == typeof(DiscountTicket))
            {
                ticket = new DiscountTicket(_ticketId, routeId, passengerName, destination, route.DepartureTime, driverName, bus);
            }
            else
            {
                throw new ArgumentException("Invalid ticket type");
            }

            _tickets.Add(ticket);
            route.AvailableSeats--;
            _ticketId++;
            return ticket;
        }
        public bool ReturnTicket(int ticketID)
        {
            var ticket = _tickets.FirstOrDefault(t => (t.TicketId == ticketID));
            if (ticket != null)
            {
                _tickets.Remove(ticket);
                _ticketId--;
                var route = _routeService.GetRouteByNumber(ticket.RouteId);
                if (route != null)
                {
                    route.AvailableSeats++;
                }
                return true;
            }
            return false;
        }

        public void SetTickets(List<Ticket> tickets)
        {
            this._tickets = tickets;
            _ticketId = tickets.Max(t => t.TicketId) + 1;
        }

        public List<Ticket> GetTicketsByRouteID(int RouteID)
        {
            return _tickets.Where(t => (RouteID == t.RouteId)).ToList();
        }

        public List<Ticket> GetAllTickets()
        {
            return _tickets;
        }
    }
}
