using WF2;
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

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}, {3}", Id, Name, Size, BikeType.Cross);
        }
    }

    
}