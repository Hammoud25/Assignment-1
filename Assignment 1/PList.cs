using System;
using System.Collections;
using System.Collections.Generic;

namespace Assignment_1
{
    class PList
    {
        public delegate void PropertyDeletedDelegate(object sender,Property property, string name);

        public event PropertyDeletedDelegate PropertyBought;
        
        public List<Property> p_list = new List<Property>();
        public List<Property> UniversalRecord = new List<Property>();

        static public int Id { get; set; }

        public PList() {
        }

        public void AddProperty(Property property)
        {
            p_list.Add(property);
            Id++;
            UniversalRecord.Add(property);
        }
        public void BuyProperty(int id,string name)
        {
            Property propTodelete = null; 
            
            foreach (Property item in p_list)
            {
                if (item.Id == id)
                {

                    propTodelete = item;
                    Id--;
                    PropertyBought(this, item, name);
                    continue;
                    
                }
            }            
            p_list.Remove(propTodelete);
        }
        public void DeleteProperty(int internalId)
        {
            p_list.RemoveAt(internalId);
        }
        private static Random rng = new Random();

        
    }
}
