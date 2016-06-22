using System;
using WF2;
using WF2.BikeClasess;

namespace HardTeilBike
{
    public class HardTeil : Bike
    {
        public string ForkType { get; set; }
        public string Material{ get; set; }

        public HardTeil(int id) : base(id)
        {

        }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}, {3}", Id, Name, Size, BikeType.HardTeil);
        }
    }
}