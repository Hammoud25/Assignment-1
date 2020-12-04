using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class ToBeList
    {
        public Buyer buyer { get; set; }
        public List<Property> toBeList { get; set; }
        public ToBeList(Buyer _buyer)
        {
            buyer = _buyer;
        }
        public void Append(List<Property> list)
        {
            toBeList = new List<Property>();
            foreach (var prop in list)
            {
                if (buyer.Credit > prop.Price)
                {
                    toBeList.Add(prop);
                }
            }
        }
    }
}
