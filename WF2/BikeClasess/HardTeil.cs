using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace WF2
{ 
    [DataContract]
    public class HardTeil : Bike
    {
        [DataMember]
        public string ForkType { get; set; }

        [DataMember]
        public string Material{ get; set; }

        public HardTeil()
        {
            
        }
        public HardTeil(int id) : base(id)
        {

        }

        public override string ToString()
        {
            return string.Format("{0}♫{1}♫{2}♫{3}♫{4}♫{5}♫{6}", Id, Name, Size, Color, BikeType.HardTeil, ForkType, Material);
        }

        public static bool TryParse(string source, out HardTeil result)
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
                result = new HardTeil(id)
                {
                    Size = size,
                    Name = splitString[1].Trim(),
                    Color = color,
                    ForkType = splitString[5].Trim(),
                    Material = splitString[6].Trim()
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