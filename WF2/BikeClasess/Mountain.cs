using WF2.BikeClasess;

namespace MountainBike
{
    public class Mountain : Bike
    {
        public string BreakType { get; set; }
        public int WheelSize { get; set; }

        public Mountain(int id) : base(id)
        {
        }
    }
}