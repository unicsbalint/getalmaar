using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using learning;

namespace learningUnitTest
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void TestApple()
        {
            Apple apple = new Apple();
            apple.SetKgPrice(100);

            apple.AddDiscount(new DiscountWithOneWeightLimit(10,0.1));

            double expected = 11 * 100 * 0.9;
            double actual = apple.GetApplePrice(11);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestApple2()
        {
            Apple apple = new Apple();
            apple.SetKgPrice(100);

            apple.AddDiscount(new DiscountWithOneWeightLimit(10, 0.1));
            apple.AddDiscount(new DiscountWithOneWeightLimit(10, 0.2));
            apple.AddDiscount(new DiscountWithOneWeightLimit(10, 0.3));
            apple.AddDiscount(new DiscountWithOneWeightLimit(20, 0.5));

            double expected = 22 * 100 * 0.5;
            double actual = apple.GetApplePrice(22);

            Assert.AreEqual(expected, actual);
        }
    }
}
