using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = NUnit.Framework.Assert;

namespace LottasLopper.Tests
{
    [TestClass]
    public class ProductTest
    {
        [TestMethod]
        public void ShouldCreateProduct()
        {
            var product = new Product(1, "Fredrik", true, true, false, false);
            Assert.AreEqual(1, product.ProductId);
            Assert.AreEqual("Fredrik", product.SellerName);
        }
    }
}
