using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace LottasLopper.Tests
{
    [TestClass]
    public class BuyerTest
    {
        [TestMethod]
        public void ShouldCreateBuyer()
        {
            var buyer = new Buyer("Erlend");
            Assert.AreEqual(buyer.Name, "Erlend");
        }
    }
}
