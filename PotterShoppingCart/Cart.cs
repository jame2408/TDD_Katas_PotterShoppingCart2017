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

            decimal discount = 1;
            int qty = books.Count();
            if (qty == 2)
            {
                discount = 0.95m;
            }
            return UnitBookPrice * books.Count() * discount;
        }
    }
}