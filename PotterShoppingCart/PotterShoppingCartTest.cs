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
            CartPriceShouldBe(0, new List<Book>());
        }

        private void CartPriceShouldBe(decimal expected, IEnumerable<Book> books)
        {
            var target = new Cart();
            var actual = target.GetPrice(books);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void When_Buy_First_Book_Should_Be_100()
        {
            var books = new List<Book>()
            {
                new Book(){ ISBN = "1", Count = 1},
            };
            CartPriceShouldBe(100, books);
        }

    }
}
