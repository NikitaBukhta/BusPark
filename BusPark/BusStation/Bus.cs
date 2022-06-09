using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusPark.BusStation
{
    internal class Bus
    {
        private static ulong _maxID;
        public string StateNumber { get; set; }
        public string Type { get; set; }
        public ushort MaxSeatCount { get; set; }

        public ulong ID { get; private set; }

        public Bus(string stateNumber, string type, ushort maxSeatCount, ulong iD)
        {
            ID = iD;
            StateNumber = stateNumber;
            Type = type;
            MaxSeatCount = maxSeatCount;

            if (_maxID < iD)
            {
                _maxID = iD;
            }
        }

        public Bus(string stateNumber, string type, ushort maxSeatCount) 
            : this(stateNumber, type, maxSeatCount, _maxID + 1) { }

        public override string ToString()
        {
            return ID + " " + StateNumber + " " + Type + " " + MaxSeatCount;
        }
    }
}
