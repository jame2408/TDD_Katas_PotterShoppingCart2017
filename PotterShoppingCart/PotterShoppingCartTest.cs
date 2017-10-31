using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PotterShoppingCart
{
    [TestClass]
    public class PotterShoppingCartTest
    {
        [TestMethod]
        public void No_Buy_Any_Books_Should_Be_0()
        {
            var target = new Cart();
            var actual = target.GetPrice(new List<Book>());
            Assert.AreEqual(0, actual);
        }
    }
}
