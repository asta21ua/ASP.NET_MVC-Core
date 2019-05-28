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
            //string[] names = new string[3];
            //names[0] = "Bob";
            //names[0] = "Joe";
            //names[0] = "Alice";
            //return View("Index", names); 

            ShoppingCart cart = new ShoppingCart { Products = Product.GetProducts() };
            Product[] productArray = { new Product { Name = "Kayak", Price = 27M},
                 new Product { Name = "Lifejacket", Price = 48.95M},
                 new Product { Name = "Soccer ball", Price = 19.50M},
                 new Product { Name = "Corner flag", Price = 34.95M}
            };
            //decimal cartTotal = cart.TotalPrices();
            //decimal arrayTotal = productArray.TotalPrices();

            //decimal arrayTotal = productArray.FilterByPrice(20).TotalPrices();
            decimal priceFilterTotal = productArray.FilterByPrice(20).TotalPrices();
            decimal nameFilterTotal = productArray.FilterByName('S').TotalPrices();

            //return View ("Index", new string [] { $"Cart Total: { cartTotal:C2}", $"Array Total: {arrayTotal:C2}"});

            //return View("Index", new string[] { $"Array Total : {arrayTotal:C2}" });

            return View("Index", new string[]
                {$"Price Total : {priceFilterTotal:C2}",
                $"Name Total : {nameFilterTotal:C2}"
            });
        }

    }
}


