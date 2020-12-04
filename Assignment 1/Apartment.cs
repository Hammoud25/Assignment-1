using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    class Apartment : Property
    {
        public override int Id { get; set; }
        public override string Title { get; set; }
        public override int Price { get; set; }
        public override string Address { get; set; }
        public int Rooms { get; set; }
        public override PropertyTypes propertyType { get => PropertyTypes.Apartment ; }

        public Apartment(AppartmentInfo apartmentInfo)
        {
            Id = PList.Id;
            Title = apartmentInfo.Title;
            Address = apartmentInfo.Address;
            Rooms = apartmentInfo.Rooms;

            Price = Rooms * 15000;
        }
    }
}
