using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    abstract class Propertyinfo : IPropertyInfo
    {
        public abstract string Title { get; set; }
        public abstract string Address { get; set; }
    }
}
