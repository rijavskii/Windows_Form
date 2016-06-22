using WF2;
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

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}, {3}", Id, Name, Size, BikeType.Mountain);
        }
    }
}