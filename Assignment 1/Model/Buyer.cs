using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Buyer : IBuyer
    {
        public string FullName { get; set; }
        public int Id { get; set; }
        public int Credit { get; set; }
        public Blist blist { get; set; }

        public Buyer(BuyerDetails buyerDetails, int Id)
        {
            this.Id = Id;
            FullName = buyerDetails.FullName;
            Credit = buyerDetails.Credit;
            blist = new Blist();
            blist.b_list = new List<Property>();
        }

        public void Buy(int id, ToBeList toBeList, PList plist)
        {
            bool itemfound = false;
            foreach (var property in toBeList.toBeList)
            {
                if (property.Id == id)
                {
                    if (Credit >= property.Price)
                    {
                        plist.BuyProperty(id,FullName);
                        blist.AddProperty(property);
                        Credit -= property.Price;
                        itemfound = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Buyer {FullName} doesn't have enough credit to" +
                            $" buy property {property.Id} of price {property.Price}");
                        itemfound = true;
                        break;
                    }
                } 
            }
            if (!itemfound)
            {
                throw new KeyNotFoundException(); 
            }
        }
    }
}
