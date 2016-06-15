using System;
using BikesHometask;

namespace WF2
{
    public class Cross : Bike
    {
        public float Wheel { get; set; }
        public int SpeedCount { get; set; }

        public override string ToString()
        {
            return "Cross : " + Environment.NewLine +
                    "Color - " + Color + ';' + Environment.NewLine +
                   "Material - " + Material + ';' + Environment.NewLine +
                   "Wheel - " + Wheel + ';' + Environment.NewLine +
                   "SpeedCount - " + SpeedCount + ";" + Environment.NewLine;
        }
    }

    
}