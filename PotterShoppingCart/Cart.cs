using System;
using System.Collections.Generic;
using System.Linq;

namespace PotterShoppingCart
{
    public class Cart
    {
        internal decimal GetPrice(IEnumerable<Book> books)
        {
            if (!books.Any())
            {
                return 0;
            }
            return 100;
        }
    }
}