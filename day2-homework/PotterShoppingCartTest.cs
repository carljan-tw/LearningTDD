using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotterShoppingCart;
using System.Collections.Generic;

namespace PotterShoppingCart.Tests
{
    [TestClass]
    public class PotterShoppingCartTest
    {
        [TestMethod]
        public void Buy_Vol1_1Book_Should_Be_100()
        {
            //arrange  
            var cart = new PotterShoppingCart();
            var products = new List<PotterBook>  
            {
                new PotterBook{Name = "Vol1", Price = 100}  
            };

            var expected = 100;

            //act  
            var actual = cart.CalculatePrice(products);

            //assert  
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Buy_Vol1_1Book_Vol2_1Book_Should_Be_190()
        {
            //arrange  
            var cart = new PotterShoppingCart();
            var products = new List<PotterBook>  
            {
                new PotterBook{Name = "Vol1", Price = 100},
                new PotterBook{Name = "Vol2", Price = 100}
            };

            var expected = 100 * 2 * 0.95m;

            //act  
            var actual = cart.CalculatePrice(products);

            //assert  
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Buy_Vol1_1Book_Vol2_1Book_Vol3_1Book_Should_Be_270()
        {
            //arrange  
            var cart = new PotterShoppingCart();
            var products = new List<PotterBook>  
            {
                new PotterBook{Name = "Vol1", Price = 100},
                new PotterBook{Name = "Vol2", Price = 100},
                new PotterBook{Name = "Vol3", Price = 100}
            };

            var expected = 100 * 3 * 0.9m;

            //act  
            var actual = cart.CalculatePrice(products);

            //assert  
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Buy_Vol1_1Book_Vol2_1Book_Vol3_1Book_Vol4_1Book_Should_Be_320()
        {
            //arrange  
            var cart = new PotterShoppingCart();
            var products = new List<PotterBook>  
            {
                new PotterBook{Name = "Vol1", Price = 100},
                new PotterBook{Name = "Vol2", Price = 100},
                new PotterBook{Name = "Vol3", Price = 100},
                new PotterBook{Name = "Vol4", Price = 100},
            };

            var expected = 100 * 4 * 0.8m;

            //act  
            var actual = cart.CalculatePrice(products);

            //assert  
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Buy_Vol1_1Book_Vol2_1Book_Vol3_1Book_Vol4_1Book_Vol5_1Book_Should_Be_375()
        {
            //arrange  
            var cart = new PotterShoppingCart();
            var products = new List<PotterBook>  
            {
                new PotterBook{Name = "Vol1", Price = 100},
                new PotterBook{Name = "Vol2", Price = 100},
                new PotterBook{Name = "Vol3", Price = 100},
                new PotterBook{Name = "Vol4", Price = 100},
                new PotterBook{Name = "Vol5", Price = 100}
            };

            var expected = 100 * 5 * 0.75m;

            //act  
            var actual = cart.CalculatePrice(products);

            //assert  
            Assert.AreEqual(expected, actual);
        }
    }
}
