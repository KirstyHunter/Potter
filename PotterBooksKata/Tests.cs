﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotterBooksKata
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Buying_SingleBook_ShouldReturn_8Euro()
        {
            var basket = new ShoppingBasket();
            var total = basket.Total();
            Assert.AreEqual(8, total);
        }
    }
}
