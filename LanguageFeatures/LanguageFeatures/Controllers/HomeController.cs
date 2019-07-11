using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            //List<string> results = new List<string>();

            //foreach (Product p in Product.GetProducts())
            //{
            //    string name = p?.Name ?? "<No Name>";
            //    decimal? price = p?.Price ?? 0;
            //    string relatedName = p ? .Related?.Name?? "<None>";
            //    results.Add($"Name: {name}, Price: {price}, Related: {relatedName}"); // String Interpolation

            //}
            //return View(results);

            //return View(new string[] { "C", "Language", "Feachers" });
            //{
            //    return View("Index", new string[] { "Bob", "Alice", "Tom" }); // Collection Initializer



            //Dictionary<string, Product> products = new Dictionary<string, Product> // Index Initializer
            //{{"Kayak", new Product {Name= "Kayak", Price = 275M} },
            //    {"Lifejacet", new Product { Name = "Lifejacet", Price = 48.9M} }

            //};

            //return View("Index", products.Keys);

            //or we can use Index Initializer in other way

            //Dictionary<string, Product> products = new Dictionary<string, Product>
            //{
            //    ["Kayak"] = new Product { Name = "Kayak", Price = 275M },
            //    ["Lifejacket"] = new Product { Name = "Lifejakcet", Price = 48.7M }

            //};

            //return View("Index", products.Keys);


            //object[] data = new object[] { 275M, 29.3M, "apple", "orange", 100, 10 }; //Pattern Matching
            //decimal total = 0;
            //for (int i= 0; i< data.Length; i++)
            //{
            //    if (data[i] is decimal d)
            //    {
            //        total += d;
            //    }

            //}

            //return View("Index", new string[] { $"Total: {total :C2}" });


            // Pattern matching in Switch Statments

            //object[] data = new object[] { 275M, 29.5M, "apple", "orange", 100, 10 };
            //decimal total = 0;
            //for (int i = 0; i < data.Length; i++)
            //{
            //    switch (data[i])

            //    {
            //        case decimal decimalValue:
            //            total += decimalValue;
            //            break;
            //        case int intValue when intValue > 50:
            //            total += intValue;
            //            break;
            //    }

            //}
            //return View("Index", new string[] { $"Total: {total:C2}" });


            //Extention Methods

            ShoppingCart cart = new ShoppingCart { Products = Product.GetProducts() };

            Product[] productArray = { new Product { Name = "Kayak", Price = 275M}, // adding Extantion Methods into Interface 
                 new Product { Name = "Lifejacket", Price = 48.95M},
                 new Product { Name = "Soccer ball", Price = 19.50M}, // creating Filtring Extantion Methods 
                 new Product { Name = "Corner flag", Price = 34.95M}
            };
            //decimal cartTotal = cart.TotalPrices();
            //decimal arrayTotal = productArray.TotalPrices();

            //return View("Index", new string[] {$"Cart Total: {cartTotal:C2}", $"Array Total: {arrayTotal:C2}" });

            //decimal arrayTotal = productArray.TotalPrices();

            //decimal arrayTotal = productArray.FilterByPrice(20).TotalPrices();

            /*decimal arrayTotal = productArray.FilterByPrice(20).TotalPrices();*/ // creating Filtring Extantion Methods 

            /*return View("Index", new string[] { $"Array Total : {arrayTotal:C2}" });*/ // creating Filtring Extantion Methods//decimal nameFilterTotal = productArray.FilterByName('S').TotalPrices();

            //return View("Index", new string[] { $"Cart Total: { cartTotal:C2}", $"Array Total: {arrayTotal:C2}" }); 


            //Lambda Expressions

            decimal priceFilterTotal = productArray.FilterByPrice(20).TotalPrices();
            decimal nameFilterTotal = productArray.FilterByName('S').TotalPrices();

            return View("Index", new string[]
                {$"Price Total : {priceFilterTotal:C2}",
                $"Name Total : {nameFilterTotal:C2}"
            });
        }

    }
}


