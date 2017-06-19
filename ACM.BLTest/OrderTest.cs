using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class OrderTest
    {
        [TestMethod]
        public void ValidateValid()
        {
            Order order = new Order();
            order.OrderDate = DateTimeOffset.Now;

            var expected = true;

            var actual = order.Validate();

            Assert.AreEqual(expected, actual);
        }

        public void ValidateMissingOrderDate()
        {
            Order order = new Order();

            var expected = false;

            var actual = order.Validate();

            Assert.AreEqual(expected, actual);
        }
    }
}
