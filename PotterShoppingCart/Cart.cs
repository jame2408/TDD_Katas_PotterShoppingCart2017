using System;
using System.Collections.Generic;
using System.Linq;

namespace PotterShoppingCart
{
    public class Cart
    {
        private const int UnitBookPrice = 100;

        internal decimal GetPrice(IEnumerable<Book> books)
        {
            if (!books.Any())
            {
                return 0;
            }
            return UnitBookPrice;
        }
    }
}