using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    class Apartment : Property
    {
        public int Rooms { get; set; }
        public override PropertyTypes propertyType { get => PropertyTypes.Apartment ; }

        public Apartment(int id, string title, string address, int rooms) : base (id, title, address)
        {
            //Id = PList.Id;
            //Title = apartmentInfo.Title;
            //Address = apartmentInfo.Address;
            //Rooms = apartmentInfo.Rooms;

            this.Rooms = rooms;

            Price = Rooms * 15000;
        }

        public override string Print()
        {
            return $"Type: {this.propertyType}, {base.Print()}";
        }
    }
}
