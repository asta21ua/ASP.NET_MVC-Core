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

        public static SimpleRepository SharedRepository => new SimpleRepository();

        public SimpleRepository()
        {
            var iinitialItems = new[]
            {


             }
        };
    }

    p

}
