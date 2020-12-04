using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace Assignment_1
{
    class Shop : Property
    {
        public override int Id { get; set; }
        public override string Title { get; set; }
        public override int Price { get; set; }
        public override string Address { get; set; }
        public int Area { get; set; }
        public string Buisness { get; set; }

        public override PropertyTypes propertyType => PropertyTypes.Shop;

        public Shop(ShopInfo shopInfo)
        {
            Id = PList.Id;
            Title = shopInfo.Title;
            Address = shopInfo.Address;
            Area = shopInfo.Area;
            Buisness = shopInfo.Buisness;

            if (Area > 50)
            {
                Price = 120000;
            }
            else
            {
                Price = 80000;
            }
        }
    }
}
