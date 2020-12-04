using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class LandInfo : Propertyinfo
    {
        public override string Title { get ; set ; }
        public override string Address { get ; set ; }
        public int Area { get; set; }
        public bool Harvestable { get; set; }
    }
}
