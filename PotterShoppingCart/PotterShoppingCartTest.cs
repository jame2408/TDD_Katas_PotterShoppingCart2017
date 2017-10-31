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

        [TestMethod]
        public void When_Buy_Two_Difference_Books_Should_Be_190()
        {
            var books = new List<Book>()
            {
                new Book(){ ISBN = "1", Count = 1},
                new Book(){ ISBN = "2", Count = 1},
            };
            CartPriceShouldBe(190, books);
        }

        [TestMethod]
        public void When_Buy_Three_Difference_Books_Should_Be_270()
        {
            var books = new List<Book>()
            {
                new Book(){ ISBN = "1", Count = 1},
                new Book(){ ISBN = "2", Count = 1},
                new Book(){ ISBN = "3", Count = 1},
            };
            CartPriceShouldBe(270, books);
        }

        [TestMethod]
        public void When_Buy_Four_Difference_Books_Should_Be_320()
        {
            var books = new List<Book>()
            {
                new Book(){ ISBN = "1", Count = 1},
                new Book(){ ISBN = "2", Count = 1},
                new Book(){ ISBN = "3", Count = 1},
                new Book(){ ISBN = "4", Count = 1},
            };
            CartPriceShouldBe(320, books);
        }

        [TestMethod]
        public void When_Buy_Five_Difference_Books_Should_Be_375()
        {
            var books = new List<Book>()
            {
                new Book(){ ISBN = "1", Count = 1},
                new Book(){ ISBN = "2", Count = 1},
                new Book(){ ISBN = "3", Count = 1},
                new Book(){ ISBN = "4", Count = 1},
                new Book(){ ISBN = "5", Count = 1},
            };
            CartPriceShouldBe(375, books);
        }

        [TestMethod]
        public void When_Buy_Three_Difference_Books_And_A_The_Same_Book_Should_Be_370()
        {
            var books = new List<Book>()
            {
                new Book(){ ISBN = "1", Count = 1},
                new Book(){ ISBN = "2", Count = 1},
                new Book(){ ISBN = "3", Count = 2},
            };
            CartPriceShouldBe(370, books);
        }

    }
}
