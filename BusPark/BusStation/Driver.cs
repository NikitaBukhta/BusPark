using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusPark.BusStation
{
    internal class Driver
    {
        private static ulong _maxID;

        public string FullName { get; set; }
        
        public float Experience { get; set; }

        public string DrivingClass { get; set; }

        public DateTime Birthdate { get; set; }

        public ulong ID { get; private set; }

        public Driver(string fullName, float experience, string drivingClass, DateTime birthdate, ulong iD)
        {
            FullName = fullName;
            Experience = experience;
            DrivingClass = drivingClass;
            Birthdate = birthdate;
            ID = iD;

            if (_maxID < iD)
            {
                _maxID = iD;
            }
        }

        public Driver(string fullName, float experience, string drivingClass, DateTime birthdate)
            : this(fullName, experience, drivingClass, birthdate, _maxID + 1) { }

        public override string ToString()
        {
            string bd = Birthdate.Day + "." + Birthdate.Month + "." + Birthdate.Year;
            return ID + "|" + FullName + "|" + Experience + "|" + DrivingClass 
                + "|" + Birthdate.ToString("dd.MM.yyyy");
        }
    }
}
