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
            var book = new int[]{ 1 };
            var basket = new ShoppingBasket();
            var total = basket.Total(book);
            Assert.AreEqual(8, total);
        }

        [Test]
        public void Buying_TwoofTheSameBook_ShouldReturn_16Euro()
        {
            var book = new int[] { 1, 1 };
            var basket = new ShoppingBasket();
            var total = basket.Total(book);
            Assert.AreEqual(16, total);
        }

        [Test]
        public void buying_TwoDifferentBooks_ShouldReturnDiscountedPrice()
        {
            var expected = 16 - (8 * 2 * 5 / 100);
            var book = new int[] { 1, 2 };
            var basket = new ShoppingBasket();
            var total = basket.Total(book);
            Assert.AreEqual(expected, total);
        }
    }

    public class ShoppingBasket
    {
        public decimal Total(int[] books)
        {
            var bookCount = books.Count();
            var total = 8 * bookCount;
            if(books.Distinct().Count() == 2)
            {
                return total - (8 * books.Distinct().Count() * 5 / 100);
            }
            return total;
        }
    }
}
