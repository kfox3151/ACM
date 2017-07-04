using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;
using System.Collections.Generic;

namespace ACM.BLTest
{
    [TestClass]
    public class OrderRepositoryTest
    {
        [TestMethod]
        public void RetrieveExisting()
        {
            OrderRepository orderRepository = new OrderRepository();
            var expected = new Order(10)
            {
                OrderDate = new DateTimeOffset(2008, 5, 1, 8, 6, 32,
                                 new TimeSpan(1, 0, 0))
            };

            var actual = orderRepository.Retrieve(10);

            Assert.AreEqual(expected.OrderDate, actual.OrderDate);
            Assert.AreEqual(expected.OrderId, actual.OrderId);
        }

        [TestMethod]
        public void RetrieveOrderDisplayTest()
        {
            //Arrange
            var orderRepository = new OrderRepository();
            var expected = new OrderDisplay()
            {
                FirstName = "Bilbo",
                LastName = "Baggins",
                OrderDate = new DateTimeOffset(2014, 4, 14, 10, 00, 00, new TimeSpan(1, 0, 0)),
                ShippingAddress = new Address()
                {
                    AddressType = 1,
                    StreetLine1 = "Bag End",
                    StreetLine2 = "Bagshot Row",
                    City = "Hobbiton",
                    State = "Shire",
                    Country = "MiddleEarth",
                    PostalCode = "144"
                },
                orderDisplayItemList = new List<OrderDisplayItem>()
                {
                    new OrderDisplayItem()
                    {
                        OrderQuantity = 2, 
                        ProductName = "Sunflowers", 
                        PurchasePrice = 15.96M 
                    },
                    new OrderDisplayItem()
                    {
                        OrderQuantity = 1, 
                        PurchasePrice = 6m, 
                        ProductName = "Rake"
                    }
                }
            };

            //Act
            var actual = orderRepository.RetrieveOrderDisplay(10);

            //Assert
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);

            Assert.AreEqual(expected.ShippingAddress.AddressType, actual.ShippingAddress.AddressType);
            Assert.AreEqual(expected.ShippingAddress.StreetLine1, actual.ShippingAddress.StreetLine1);
            Assert.AreEqual(expected.ShippingAddress.StreetLine2, actual.ShippingAddress.StreetLine2);
            Assert.AreEqual(expected.ShippingAddress.City, actual.ShippingAddress.City);
            Assert.AreEqual(expected.ShippingAddress.State, actual.ShippingAddress.State);
            Assert.AreEqual(expected.ShippingAddress.Country, actual.ShippingAddress.Country);
            Assert.AreEqual(expected.ShippingAddress.PostalCode, actual.ShippingAddress.PostalCode);

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(expected.orderDisplayItemList[i].OrderQuantity, actual.orderDisplayItemList[i].OrderQuantity);
                Assert.AreEqual(expected.orderDisplayItemList[i].ProductName, actual.orderDisplayItemList[i].ProductName);
                Assert.AreEqual(expected.orderDisplayItemList[i].PurchasePrice, actual.orderDisplayItemList[i].PurchasePrice);
            }
        }
    }
}
