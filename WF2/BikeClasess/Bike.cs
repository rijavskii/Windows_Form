using System.Runtime.Serialization;

namespace WF2
{
    [DataContract]
    public class Bike
    {
        [DataMember]
        public int Id ;

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int Size { get; set; }

        [DataMember]
        public int Color { get; set; }


        public Bike(int id)
        {
            Id = id;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}, {3}, {4}", Id, Name, Size, Color, this.GetType().Name);
        }

        protected Bike()
        {
            
        }
    }
}