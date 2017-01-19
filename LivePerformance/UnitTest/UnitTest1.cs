using Microsoft.VisualStudio.TestTools.UnitTesting;
using LivePerformance.Logic;
using LivePerformance.Data;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        private ProductRepository _productrepo;

        [TestInitialize]
        public void TestInitialize()
        {
            _productrepo = new ProductRepository(new MssqlProductContext());
        }

        [TestMethod]
        public void CheckProduct()
        {
            Assert.AreEqual(false, _productrepo.CheckProduct("test", 1, 1, 0));
            Assert.AreEqual(true, _productrepo.CheckProduct("Frisdrank", 1, 2, 0));
        }

        [TestMethod]
        public void AddProduct()
        {
            Assert.AreEqual(false, _productrepo.CheckProduct("test", 1, 1, 0));
            _productrepo.AddProduct("test", 1, 1, 0);
            Assert.AreEqual(true, _productrepo.CheckProduct("test", 1, 1, 0));
            _productrepo.DeleteProduct(_productrepo.GetProductId("test", 1, 1, 0));
        }
    }
}
