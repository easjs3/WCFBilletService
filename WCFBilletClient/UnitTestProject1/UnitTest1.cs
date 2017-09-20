using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestProject1.BilletService;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BilPrisUdenRabat()
        {
            using (var client = new BilletService.BilletClient("BasicHttpsBinding_IBillet"))
            {
                var pris = client.BilPrisUdenRabatStorebælt();
                Assert.AreEqual(240, pris);
            }
        }
    }
}
