using NUnit.Framework;
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
            var total = basket.Total(1);
            Assert.AreEqual(8, total);
        }

        [Test]
        public void Buying_TwoofTheSameBook_ShouldReturn_16Euro()
        {
            var basket = new ShoppingBasket();
            var total = basket.Total(2);
            Assert.AreEqual(16, total);
        }
    }

    public class ShoppingBasket
    {
        public int Total(int bookCount)
        {
            return 8 * bookCount;
        }
    }
}
