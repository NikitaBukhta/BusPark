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

        public DateTime DepartureTime { get; set; }

        public Shedule (ulong driverID, ulong busID, ulong routeID, DateTime departureTime)
        {
            DriverID = driverID;
            BusID = busID;
            RouteID = routeID;
            DepartureTime = departureTime;
        }

        public override string ToString()
        {
            return DriverID + "|" + BusID + "|" + RouteID + "|" + DepartureTime.ToString("dd.MM.yyyy") 
                + "|" + DepartureTime.ToString("hh:mm:ss");
        }
    }
}
