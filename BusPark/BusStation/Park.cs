using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusPark.BusStation
{
    internal class Park
    {
        public string Number { get; set; }

        public string Address { get; set; }

        public List<Bus> Buses { get; set; }

        public List<Route> Routes { get; set; }

        public List<Driver> Drivers { get; set; }

        public List<Shedule> Shedules { get; set; }

        public Park(string number, string address)
        {
            Number = number;
            Address = address;

            Buses = new List<Bus>();
            Routes = new List<Route>();
            Drivers = new List<Driver>();
            Shedules = new List<Shedule>();
        }
    }
}
