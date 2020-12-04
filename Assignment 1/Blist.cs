using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Blist
    {
        public List<Property> b_list = new List<Property>();
        public static int Id { get; private set; }
        public Buyer buyer { get; set; }
        public void AddProperty(Property property)
        {
            b_list.Add(property);
            Id++;            
        }

    }
}
