using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment_1
{
    static class Utilities
    {
        public static LandInfo CreateLandDetails()
        {
            LandInfo landInfo = new LandInfo();
            landInfo.Title = RandomString(10);
            landInfo.Area = random.Next(10, 20);
            landInfo.Harvestable = RandomBool();
            landInfo.Address = landInfo.Title +
                "/" + landInfo.Title +
                "/" + landInfo.Title;
            return landInfo;
        }
        public static ShopInfo CreateShopDetails()
        {
            ShopInfo shopInfo = new ShopInfo();
            shopInfo.Title = RandomString(10);
            shopInfo.Area = random.Next(30, 100);
            shopInfo.Buisness = Randombuissnes();
            shopInfo.Address = shopInfo.Title +
                "/" + shopInfo.Title +
                "/" + shopInfo.Title;
            return shopInfo;
        }
        public static AppartmentInfo CreateApartmentDetails()
        {
            AppartmentInfo appartmentInfo = new AppartmentInfo();
            appartmentInfo.Title = RandomString(10);
            appartmentInfo.Rooms = random.Next(4,10);
            appartmentInfo.Address = appartmentInfo.Title +
                "/" + appartmentInfo.Title +
                "/" + appartmentInfo.Title;
            return appartmentInfo;
        }
        public static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public static bool RandomBool()
        {
            bool r = false;
            int b = random.Next(0, 2);
            if (b == 0)
            {
                r = true;
            }
            return r;
        }
        public static string Randombuissnes()
        {
            string[] buisnesses = new string[3] { "food", "retail", "repair" };
            int s = random.Next(0,3);
            string r = buisnesses[s];
            return r;
        }
        public static List<Property> Shuffle<Property>(List<Property> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                Property value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
            return list;
        }
    }
}