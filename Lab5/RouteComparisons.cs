using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RouteLib;

namespace Lab5
{
    public class RouteComparisonsSorting
    {
        public static int CompareByFinalDestination(Route x, Route y)
        {
            return string.Compare(x.FinalDestination, y.FinalDestination, StringComparison.Ordinal);
        }

        public static int CompareByDepartureTIme(Route x, Route y)
        {
            return DateTime.Compare(x.DepartureTime, y.DepartureTime);
        }

        public static int CompareByRouteNumbers(Route x, Route y)
        {
            return x.RouteNumber.CompareTo(y.RouteNumber);
        }

        public static int CompareByTotalSeats(Route x, Route y)
        {
            return x.TotalSeats.CompareTo(y.TotalSeats);    
        }

        public static int CompareByAvailableSeats(Route x, Route y)
        {
            return x.AvailableSeats.CompareTo(y.AvailableSeats);
        }
    }

    public class RouteComparisonsFiltration
    {
        public static List<Route> FilterByAvailableSeats(List<Route> routes, int minseats)
        {
            return routes.Where(r => (r.AvailableSeats >= minseats)).ToList();
        }

        public static List<Route> FilterByDestination(List<Route> routes, string destination)
        {
            return routes.Where(r => (r.FinalDestination == destination) || r.IntermediatePoint.Any(point => point.Contains(destination))).ToList();
        }

        public static List<Route> FilterByDepartureTime(List<Route> routes, DateTime DepartureTime)
        {
            return routes.Where(r => r.DepartureTime >=  DepartureTime).ToList();
        }
    }
}