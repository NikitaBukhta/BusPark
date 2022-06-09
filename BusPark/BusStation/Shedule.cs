using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusPark.BusStation
{
    internal class Shedule
    {
        public ulong DriverID { get; private set; }

        public ulong BusID { get; private set; }

        public ulong RouteID { get; private set; }

        DateTime DepartureTime { get; set; }

        public Shedule (ulong driverID, ulong busID, ulong routeID, DateTime departureTime)
        {
            DriverID = driverID;
            BusID = busID;
            RouteID = routeID;
            DepartureTime = departureTime;
        }

        public override string ToString()
        {
            string date = DepartureTime.Day + "." + DepartureTime.Month + "." + DepartureTime.Year;
            string time = DepartureTime.Hour + ":" + DepartureTime.Minute;
            return DriverID + "|" + BusID + "|" + RouteID + "|" + date + " " + time;
        }
    }
}
