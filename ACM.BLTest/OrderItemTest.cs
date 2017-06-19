using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class OrderItemTest
    {
        [TestMethod]
        public void ValidateValid()
        {
            OrderItem orderItem = new OrderItem();
            orderItem.PurchacePrice = 50;
            orderItem.OrderQuantity = 3;
            orderItem.ProductId = 1;

            var expected = true;

            var actual = orderItem.Validate();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingPurchacePrice()
        {
            OrderItem orderItem = new OrderItem();
            orderItem.OrderQuantity = 5;
            orderItem.ProductId = 1;

            var expected = false;

            var actual = orderItem.Validate();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingOrderQuantity()
        {
            OrderItem orderItem = new OrderItem();
            orderItem.PurchacePrice = 4;
            orderItem.ProductId = 1;

            var expected = false;

            var actual = orderItem.Validate();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingProductId()
        {
            OrderItem orderItem = new OrderItem();
            orderItem.OrderQuantity = 5;
            orderItem.PurchacePrice = 5;

            var expected = false;

            var actual = orderItem.Validate();

            Assert.AreEqual(expected, actual);
        }
    }
}
