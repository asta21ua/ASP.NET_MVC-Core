using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Models
{
    public class Product
    {
        public Product(bool stock = true)                     //Read-Only Automatically Implemented Properties
        {
            InStock = stock;
        }
        public string Name { get; set; }
        public string Category { get; set; } = "Watersports"; //Auto-Implemented Property Initializer
        public decimal? Price { get; set; }
        public Product Related { get; set; }
        public bool InStock { get; }                         //Read-Only Automatically Implemented Properties
        public static Product[] GetProducts()
        {
            Product kayak = new Product
            {
                Name = "Kayak",
                Category = "Water Craft",
                Price = 275M
            };
             
            Product lifejacket = new Product(false)         //Read-Only Automatically Implemented Properties
            {
                Name = "LifeJecket",
                Price = 48.95M
            };

            kayak.Related = lifejacket;
            return new Product[] { kayak, lifejacket, null };
        }

    }
}
