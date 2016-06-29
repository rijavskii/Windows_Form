using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace WF2
{
    [DataContract]
    public class Cross : Bike
    {
        [DataMember]
        public float Wheel { get; set; }

        [DataMember]
        public int SpeedCount { get; set; }

        public Cross()
        {
            
        }

        public Cross(int id) : base(id)
        {
        }

        public override string ToString()
        {
            return string.Format("{0}♫{1}♫{2}♫{3}♫{4}♫{5}♫{6}", Id, Name, Size, Color, BikeType.Cross, Wheel, SpeedCount);
        }

        public static Boolean TryParse(string source, out Cross result)
        {
            result = null;
            List<String> splitString = source.Split('♫').ToList();
            try { 
            
                int id = splitString[0].GetInt();
                if (id == -1)
                {
                    throw  new Exception("Cannot parse Id for bike");
                }

                int size = splitString[2].GetInt();
                if (size == -1)
                {
                    throw new Exception("Cannot parse Size for bike");
                }

                int color = splitString[3].GetInt();
                if(color == -1)
                {
                    throw new Exception("Cannot parse Color for bike");
                }

                int speedCount = splitString[6].GetInt();
                if (speedCount == -1)
                {
                    throw new Exception("Cannot parse Speed Count for bike");
                }

                float wheel = splitString[5].GetFloat();
                if (wheel == 0)
                {
                    throw new Exception("Cannot parse Wheel for bike");
                }

                result = new Cross(id)
                {
                    Size = size,
                    Name = splitString[1].Trim(),
                    Color = color,
                    Wheel = wheel,
                    SpeedCount = speedCount

                };

                return true;

            }
            catch (Exception)
            {
                
                return false;
            }
            
            
        }
    }

    
}