using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductTest
    {
        [TestMethod]
        public void ValidateValid()
        {
            var product = new Product();
            product.ProductName = "TheProduct";
            product.CurrentPrice = 10;

            var expected = true;

            var actual = product.Validate();

            Assert.AreEqual(expected, actual);
        }

        public void ValidateMissingProductName()
        {
            var product = new Product();
            product.CurrentPrice = 10;

            var expected = false;

            var actual = product.Validate();

            Assert.AreEqual(expected, actual);
        }

        public void ValidateMissingCurrentPrice()
        {
            var product = new Product();
            product.ProductName = "TheProduct";

            var expected = false;

            var actual = product.Validate();

            Assert.AreEqual(expected, actual);
        }

    }
}
