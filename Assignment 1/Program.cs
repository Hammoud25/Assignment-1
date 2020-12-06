using System;
using System.Collections.Generic;

namespace Assignment_1
{
    class Program
    {
        static void Main()
        {
            IProperty property1 = new Apartment(1, "title", "address", 2);
            IProperty property2 = new Land(null);

            var properties = new List<IProperty> { property1, property2 };

            foreach (var item in properties)
            {
                item.Print();
            }
            

            PList plist = new PList();
            List<Buyer> buyers = new List<Buyer>();
            plist.PropertyBought += OnPropertyBought;

            for (int i = 5; i > 0; i--)
            {
                AppartmentInfo apartmentInfo = Utilities.CreateApartmentDetails();
                Apartment apartment = new Apartment(apartmentInfo);
                plist.AddProperty(apartment);
            }
            for (int i = 2; i > 0; i--)
            {
                LandInfo landInfo = Utilities.CreateLandDetails();
                Land land = new Land(landInfo);
                plist.AddProperty(land);
            }
            for (int i = 3; i > 0; i--)
            {
                ShopInfo shopInfo = Utilities.CreateShopDetails();
                Shop shop = new Shop(shopInfo);
                plist.AddProperty(shop);
            }
            for (int i = 0; i < 3; i++)
            {
                BuyerDetails buyerDetails = new BuyerDetails();
                int[] Credits = new int[3] { 60000, 10000, 400000 };
                buyerDetails.Credit = Credits[i];
                buyerDetails.FullName = Utilities.RandomString(5) + "" + Utilities.RandomString(5);
                var buyer = new Buyer(buyerDetails, i + 1);
                buyers.Add(buyer);
            }


            // Print
            foreach (var property in plist.p_list)
            {

                Console.WriteLine(property.Print());
            }

            Console.WriteLine("");
            foreach (var property in plist.p_list)
            {
                if (property.propertyType == PropertyTypes.Land)
                {
                    Console.WriteLine(
                    $"Type: {property.propertyType}, Id: {property.Id}, Title: {property.Title}"
                    );
                }
            }

            Console.WriteLine("");

            foreach (var property in plist.p_list)
            {

                if (property.Price > 45000 && property.Price < 100000)
                {
                    Console.WriteLine(
                    $"Type: {property.propertyType}, Id: {property.Id}, Title: {property.Title}, Price: {property.Price}"
                    );
                }
            }
            Console.WriteLine("");
            var CheapestPrice = int.MaxValue;
            foreach (var property in plist.p_list)
            {
                CheapestPrice = Math.Min(property.Price, CheapestPrice);
            }
            var slist = new ShuffledList(plist);
            foreach (var buyer in buyers)
            {
                if (buyer.Credit < CheapestPrice)
                {
                    Console.WriteLine($"Buyer {buyer.FullName} cannot buy anything!");
                    Console.WriteLine("");
                    continue;
                }
                ToBeList To_BeList = new ToBeList(buyer);
                To_BeList.Append(slist.Slist);
                foreach (var property in To_BeList.toBeList)
                {
                    buyer.Buy(property.Id, To_BeList, plist);
                }
                Console.WriteLine("");
            }
            foreach (var buyer in buyers)
            {
                Console.WriteLine($"Name: {buyer.FullName}.");
                Console.WriteLine($"N.b of owned properties: {buyer.blist.b_list.Count}.");
                Console.WriteLine($"Credit: {buyer.Credit}");
                Console.WriteLine("");
            }

            foreach (var prop in plist.UniversalRecord)
            {
                if (prop.Id == 2)
                {
                    var p2 = prop;
                    p2.Title = Utilities.RandomString(5);
                    Console.WriteLine($"Type: {p2.propertyType}, Title: {p2.Title}, Id: {p2.Id}, Price: {p2.Price}, Address: {p2.Address}.");
                    break;
                }
            }
            Console.WriteLine("");
            for (int i = 0; i < 2; i++)
            {
                int randomproperty = Utilities.random.Next(0, plist.p_list.Count);
                plist.DeleteProperty(randomproperty);
            }
            foreach (var property in plist.p_list)
            {
                Console.WriteLine(
                    $"Type: {property.propertyType}, Id: {property.Id}, Title: {property.Title}"
                    );
            }
        }
        static void OnPropertyBought(object Thisone, Property property, string name)
        {
            Console.WriteLine($"{ property.propertyType} " +
            $"with ID { property.Id} " +
            $"was purchased by {name} " +
            $"for {property.Price}" +
            "$.");
        }
    }
}