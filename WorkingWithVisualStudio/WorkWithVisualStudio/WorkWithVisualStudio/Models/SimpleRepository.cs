using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkWithVisualStudio.Models
{
    public class SimpleRepository
    {
        private static SimpleRepository sharedRepository = new SimpleRepository();
        private Dictionary<string, Product> products = new Dictionary<string, Product>();

        public static SimpleRepository SharedRepository => sharedRepository;

        public SimpleRepository()
        {
            var initialItems = new[]

            { new Product {Name = "Kayak", Price=254M },
                new Product { Name = "Lifejacket", Price = 56.42M },
                new Product { Name = "Soccer ball", Price = 15.4M},
                new Product { Name = "Corner Flag", Price = 20.4M }
            };

            foreach (var p in initialItems)
            {
                AddProduct(p);
            }
        }

        public IEnumerable<Product> Products => products.Values;
        public void AddProduct(Product p) => products.Add(p.Name, p);
    }

}

