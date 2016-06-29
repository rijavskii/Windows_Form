using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;


namespace WF2
{
    [DataContract]
    public class Mountain : Bike
    {
        //public Cross()
        //{

        //}
        [DataMember]
        public string BreakType { get; set; }

        [DataMember]
        public int WheelSize { get; set; }

        public Mountain()
        {
            
        }
        public Mountain(int id) : base(id)
        {
        }

        public override string ToString()
        {
            return string.Format("{0}♫ {1}♫ {2}♫ {3}♫ {4}♫ {5}♫ {6}", Id, Name, Size, Color, BikeType.Mountain, BreakType, WheelSize);
        }

        public static Boolean TryParse(string source, out Mountain result)
        {
            result = null;
            List<String> splitString = source.Split('♫').ToList();
            try
            {
                int id = splitString[0].GetInt();
                if (id == -1)
                {
                    throw new Exception("Cannot parse Id for bike");
                }

                int size = splitString[2].GetInt();
                if (size == -1)
                {
                    throw new Exception("Cannot parse Size for bike");
                }

                int color = splitString[3].GetInt();
                if (size == -1)
                {
                    throw new Exception("Cannot parse Color for bike");
                }

                int wheelSize = splitString[6].GetInt();
                if (wheelSize == -1)
                {
                    throw new Exception("Cannot parse Color for bike");
                }

                result = new Mountain(id)
                {
                    Size = size,
                    Name = splitString[1].Trim(),
                    Color = color,
                    BreakType = splitString[6].Trim(),
                    WheelSize = wheelSize
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