using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = NUnit.Framework.Assert;
using StringAssert = NUnit.Framework.StringAssert;

namespace LottasLopper.Tests
{
    [TestClass]
    public class ProductViewTest
    {
        private readonly Product _product = new Product(1, "Thanh", true, true, true, true);

        [TestMethod]
        public void ShouldAddProduct()
        {
            var productView = new ProductView();
            productView.AddProduct(_product);
            Assert.AreEqual(_product, productView.ProductList[0]);
        }

        [TestMethod]
        public void ShouldBuyProduct()
        {
            var productView = new ProductView();
            productView.AddProduct(_product);
            productView.BuyProduct(_product, "Erlend");
            Assert.AreEqual(0, productView.ProductList.Count);
        }

        [TestMethod]
        public void ShouldCreateString()
        {
            var productView = new ProductView();
            var expectedString = "\t\t\t\t\tErlend just bought product #1 from " 
                + _product.SellerName 
                + " with a minor dent " 
                + "and basic features " 
                + "and some customization " 
                + "and a missing piece";
            string actualString = productView.StringBuilder(_product, "Erlend").ToString();
            StringAssert.AreEqualIgnoringCase(expectedString, actualString);
        }
    }
}
