using System;

namespace BikesHometask
{
    public class Bike
    {
        public string Color { get; set; }
        public string Material { get; set; }

        public override string ToString()
        {
            return "Color - " + Color + ';' + Environment.NewLine + 
                   "Material - " + Material + Environment.NewLine;
        }
    }
}