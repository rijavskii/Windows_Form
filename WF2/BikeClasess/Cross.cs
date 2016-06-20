using WF2.BikeClasess;

namespace CrossBike
{
    public class Cross : Bike
    {
        public float Wheel { get; set; }
        public int SpeedCount { get; set; }
        

        public Cross(int id) : base(id)
        {
        }
    }

    
}