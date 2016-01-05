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
    }
}
