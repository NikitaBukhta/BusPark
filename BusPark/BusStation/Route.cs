using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusPark.BusStation
{
    internal class Route
    {
        private static ulong _maxID;

        public ushort Number { get; set; }

        public string Begin { get; set; }

        public string End { get; set; }

        public ushort Duration { get; set; }   // in minutes;

        public ushort Interval { get; set; }

        public ulong ID { get; private set; }

        public Route (ushort number, string begin, string end, ushort duration, ushort interval, ulong iD)
        {
            ID = iD;
            Number = number;
            Begin = begin;
            End = end;
            Duration = duration;
            Interval = interval;

            if (_maxID < iD)
            {
                _maxID = iD;
            }

        }

        public Route(ushort number, string begin, string end, ushort duration, ushort interval) 
            : this(number, begin, end, duration, interval, _maxID + 1) { }

        public override string ToString()
        {
            return ID + "|" + Number + "|" + Begin + "|" + End + "|" + Duration + "|" + Interval;
        }
    }
}
