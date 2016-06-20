using System;
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
    }
}