using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    class Land : Property
    {
        public override int Id { get; set; }
        public override string Title { get; set; }
        public override int Price { get; set; }
        public override string Address { get; set; }
        public int Area { get; set; }
        public bool CanHarvest { get; set; }

        public override PropertyTypes propertyType => PropertyTypes.Land;

        public Land(LandInfo landInfo)
        {
            Id = PList.Id;
            Title = landInfo.Title;
            Address = landInfo.Address;
            Area = landInfo.Area;
            CanHarvest = landInfo.Harvestable;

            Price = Area * 3000;
        }

    }
}
