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

        [TestMethod]
        public void When_Buy_First_Book_Should_Be_100()
        {
            var target = new Cart();
            var books = new List<Book>()
            {
                new Book(){ ISBN = "1", Count = 1},
            };
            var actual = target.GetPrice(books);
            Assert.AreEqual(100, actual);
        }

    }
}
