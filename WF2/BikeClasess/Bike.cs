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
        
    }
}