using System.Runtime.InteropServices;

namespace WF2.BikeClasess
{
    public class Bike
    {
        public readonly int Id ;
        public string Name { get; set; }
        public int Size { get; set; }
        public string Color { get; set; }

        public Bike(int id)
        {
            Id = id;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}, {3}", Id, Name, Size, this.GetType().Name);
        }
    }
}