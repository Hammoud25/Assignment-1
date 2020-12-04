using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class ShuffledList: PList
    {
        public List<Property> Slist = new List<Property>();
        public ShuffledList(PList plist)
        {
            Slist = Utilities.Shuffle(plist.p_list);
        }
    }
}
