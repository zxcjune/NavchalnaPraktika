using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.SqlServer.Server;

namespace RouteLib
{
    public interface IRouteService
    {
        void UpdateRoute(Route updatedRoute);
        void DeleteRoute(int routeId);
        void AddRoute(Route route);
        int GetNextRouteNumber();
        void SetRoutes(List<Route> routes);
        List<Route> GetAllRoutes();
        Route GetRouteByNumber(int routeNumber);
        Route FindNearestRoute(string _finalDestination, DateTime currentTime);

    }

    public class Route
    {
        private int _routeNumber;

        public int RouteNumber { get { return _routeNumber; } set { _routeNumber = value; } }

        private string _startPoint;
        public string StartPoint { get { return _startPoint; } set { _startPoint = value; } }

        private string _finalDestination;
        public string FinalDestination { get { return _finalDestination; } set { _finalDestination = value; } }

        private List<string> _intermediatePoint;

        public List<string> IntermediatePoint { get { return _intermediatePoint; } set { _intermediatePoint = value; } }


        private DateTime _departureTime;
        public DateTime DepartureTime { get { return _departureTime; } set { _departureTime = value; } }

        private DateTime _arrivalTime;
        public DateTime ArrivalTime { get { return _arrivalTime; } set { _arrivalTime = value; } }

        private string _bus;
        public string Bus { get { return _bus; } set { _bus = value; } }

        private string _driverName;

        public string DriverName { get { return _driverName; } set { _driverName = value; } }

        private int _totalSeats;
        public int TotalSeats { get { return _totalSeats; } set { _totalSeats = value; } }

        public int _availableSeats;
        public int AvailableSeats { get { return _availableSeats; }set { _availableSeats = value; } }

    }
    public class RouteService : IRouteService
    {
        private List<Route> _routes;
        private int _nextRouteNumber;
        public RouteService()
        {
            _routes = new List<Route>();
            _nextRouteNumber = 1;
        }

        public List<Route> GetAllRoutes()
        {
            return _routes;
        }

        public Route GetRouteByNumber(int routeNumber)
        {
            return _routes.FirstOrDefault(r => r.RouteNumber == routeNumber);
        }

        public Route FindNearestRoute(string finalDestination, DateTime currenttime)
        {
            return _routes.Where(r => (r.FinalDestination == finalDestination
            || r.IntermediatePoint.Contains(finalDestination)
            && r.AvailableSeats > 0
            && r.DepartureTime >= currenttime)).OrderBy(r => r.DepartureTime).FirstOrDefault(); ;    
        }

        public void AddRoute(Route route)
        {
            route.RouteNumber = _nextRouteNumber;
            _routes.Add(route);
            _nextRouteNumber++;
        }

        public int GetNextRouteNumber()
        {
            return _nextRouteNumber;
        }
        public void SetRoutes(List<Route> routes)
        {
            this._routes = routes;
            _nextRouteNumber = _routes.Count > 0 ? _routes.Max(r => r.RouteNumber) + 1 : 1;
        }

        public void DeleteRoute(int routeId)
        {
            var routeToRemove = _routes.FirstOrDefault(r => r.RouteNumber == routeId);
            if(routeToRemove != null)
            {
                _routes.Remove(routeToRemove);
            }
        }
        public void UpdateRoute(Route updatedRoute)
        {
            var route = _routes.FirstOrDefault(r => r.RouteNumber == updatedRoute.RouteNumber);
            if (route != null)
            {
                route.FinalDestination = updatedRoute.FinalDestination;
                route.DepartureTime = updatedRoute.DepartureTime;
                route.ArrivalTime = updatedRoute.ArrivalTime;
                route.IntermediatePoint = updatedRoute.IntermediatePoint;
                route.Bus = updatedRoute.Bus;
                route.StartPoint = updatedRoute.StartPoint;
                route.DriverName = updatedRoute.DriverName;
                route.TotalSeats = updatedRoute.TotalSeats;
                route.AvailableSeats = updatedRoute.AvailableSeats;
            }
        }
    }
}
