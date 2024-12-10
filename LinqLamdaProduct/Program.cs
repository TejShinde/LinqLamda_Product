using System;
using System .Collections .Generic;
using System .Linq;
using System .Text;
using System .Threading .Tasks;

namespace LinqLamdaProduct
    {
    internal class Program
        {
        static void Main ( string[] args )
            {
            List<ProductLamda> ListObj = new List<ProductLamda>()
            {
                new ProductLamda{Id=1,Name="Mouse",Price=799,CompanyName="Dell"},
                new ProductLamda{Id=2,Name="Mouse",Price=699,CompanyName="Lenovo"},
                new ProductLamda{Id=3,Name="Laptop",Price=34799,CompanyName="Dell"},
                new ProductLamda{Id=4,Name="Laptop",Price=45799,CompanyName="Sony"},
                new ProductLamda{Id=5,Name="Laptop",Price=38799,CompanyName="Lenovo"},
                new ProductLamda{Id=6,Name="Keyboard",Price=599,CompanyName="Dell"},
                new ProductLamda{Id=7,Name="Keyboard",Price=999,CompanyName="Microsoft"},
                new ProductLamda{Id=8,Name="RAM 4GB",Price=2799,CompanyName="Corsair"},
                new ProductLamda{Id=9,Name="Speaker",Price=5799,CompanyName="Sony"},
                new ProductLamda{Id=10,Name="USB Mouse",Price=1299,CompanyName="Microsoft"},
            };

          
            var allProducts = from productVar in ListObj select productVar; //(ListObj is object name here,it can be table name)
            Console .WriteLine("All Products:");
            foreach ( var p in allProducts ) Console .WriteLine(p);

           
            var result = from productVar in ListObj where productVar .Price > 1500 select productVar;
            Console .WriteLine("\nProducts with Price > 1500:");
            foreach ( var p in result ) Console .WriteLine(p);

           
            var priceRange = from productVar in ListObj where productVar .Price >= 10000 && productVar .Price <= 40000 select productVar;
            Console .WriteLine("\nProducts with Price Between 10000 and 40000:");
            foreach ( var p in priceRange ) Console .WriteLine(p);

            
            var dellProducts = from productVar in ListObj where productVar .CompanyName == "Dell" select productVar;
            Console .WriteLine("\nDell Products:");
            foreach ( var p in dellProducts ) Console .WriteLine(p);

            // All laptops
            var laptops = from productVar in ListObj where productVar .Name .Contains("Laptop") select productVar;
            Console .WriteLine("\nLaptops:");
            foreach ( var p in laptops ) Console .WriteLine(p);

           
            var companyStartsWithM = from productVar in ListObj where productVar .CompanyName .StartsWith("M") select productVar;
            Console .WriteLine("\nProducts whose Company Name starts with 'M':");
            foreach ( var p in companyStartsWithM ) Console .WriteLine(p);

           
            var cheapMice = from productVar in ListObj where productVar .Name .Contains("Mouse") && productVar .Price < 1000 select productVar;
            Console .WriteLine("\nMouse Products with Price < 1000:");
            foreach ( var p in cheapMice ) Console .WriteLine(p);

            // Products ordered by price descending
            var descendingPrice = from productVar in ListObj orderby productVar .Price descending select productVar;
            Console .WriteLine("\nProducts Descending by Price:");
            foreach ( var p in descendingPrice ) Console .WriteLine(p);

            // Products ordered by company name ascending
            var ascendingCompany = from productVar in ListObj orderby productVar .CompanyName select productVar;
            Console .WriteLine("\nProducts Ascending by Company Name:");
            foreach ( var p in ascendingCompany ) Console .WriteLine(p);

            // Keyboards ordered by price ascending
            var keyboardsByPrice = from productVar in ListObj where productVar .Name .Contains("Keyboard") orderby productVar .Price select productVar;
            Console .WriteLine("\nKeyboards Ascending by Price:");
            foreach ( var p in keyboardsByPrice ) Console .WriteLine(p);


            //------------------------------------Using Lambda-------------------------------

            // Display all products descending order by their price
            var descPrice = ListObj .OrderByDescending(p => p .Price);
            Console .WriteLine("\nProducts Descending by Price:");
            foreach ( var p in descPrice ) Console .WriteLine(p);

           
            var productId5 = ListObj .FirstOrDefault(p => p .Id == 5);
            Console .WriteLine($"\nProduct with Id 5:\n{productId5}");

       
            var priceLess5000 = ListObj .Where(p => p .Price < 5000);
            Console .WriteLine("\nProducts with Price < 5000:");
            foreach ( var p in priceLess5000 ) Console .WriteLine(p);

           
            var top3MaxPrice = ListObj .OrderByDescending(p => p .Price) .Take(3);
            Console .WriteLine("\nTop 3 Products with Maximum Price:");
            foreach ( var p in top3MaxPrice ) Console .WriteLine(p);
            //foreach( ProductLamda item in top3MaxPrice )
            //    {
            //    Console .WriteLine("\nTop 3 Products with Maximum Price:");
            //    }


            var top5MinPrice = ListObj .OrderBy(p => p .Price) .Take(5);
            Console .WriteLine("\nTop 5 Products with Minimum Price:");
            foreach ( var p in top5MinPrice ) Console .WriteLine(p);

            }
        }
    }
