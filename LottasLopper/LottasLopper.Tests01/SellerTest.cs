using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = NUnit.Framework.Assert;

namespace LottasLopper.Tests
{
    [TestClass]
    public class SellerTest
    {
        [TestMethod]
        public void ShouldCreateSeller()
        {
            var seller = new Seller("Erlend");
            Assert.AreEqual("Erlend", seller.Name);
        }

        [TestMethod]
        public void ShouldRegisterProduct()
        {
            var seller = new Seller("Erlend");
            var product = seller.RegisterProduct(true, true, true, true);
            Assert.AreEqual(1, product.ProductId);
            Assert.AreEqual("Erlend", product.SellerName);
        }
    }
}
