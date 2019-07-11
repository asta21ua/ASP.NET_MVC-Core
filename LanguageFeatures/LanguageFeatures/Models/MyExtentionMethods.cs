using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Models
{
    public static class MyExtentionMethods
    {
        public static decimal TotalPrices(this IEnumerable<Product> products) // Adding Extantion Methods into Interface
        {
            decimal total = 0;
            foreach (Product prod in products)
            {
                total += prod?.Price ?? 0;
            }
            return total;
        }

        public static IEnumerable<Product> FilterByPrice(this IEnumerable<Product> productEnum, decimal minimumPrice) //Creating Filtring Extantion Methods
        {
            foreach (Product prod in productEnum)
            {
                if ((prod?.Price ?? 0) >= minimumPrice)
                {
                    yield return prod;
                }
            }
        }
        
        //Lambda Expressions

        public static IEnumerable<Product> FilterByName(this IEnumerable<Product> productEnum, char firstLetter)

        {
            foreach (Product prod in productEnum)
            {
                if (prod?.Name?[0] == firstLetter)
                {
                    yield return prod;
                }
            }
        }

    }

}


