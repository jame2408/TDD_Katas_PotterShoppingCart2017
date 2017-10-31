﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace PotterShoppingCart
{
    public class Cart
    {
        private const int UnitBookPrice = 100;
        private readonly Dictionary<int, decimal> _discount = new Dictionary<int, decimal>()
        {
            {1, 1m },
            {2, 0.95m },
        };

        internal decimal GetPrice(IEnumerable<Book> books)
        {
            if (!books.Any())
            {
                return 0;
            }

            var qty = books.Count();
            return UnitBookPrice * qty * _discount[qty];
        }
    }
}