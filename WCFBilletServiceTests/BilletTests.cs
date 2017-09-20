using Microsoft.VisualStudio.TestTools.UnitTesting;
using WCFBilletService;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFBilletService.Tests
{
    [TestClass()]
    public class BilletTests
    {
        [TestMethod()]
        public void BilPrisUdenRabatStorebæltTest()
        {
            //arrange
            Billet minbillet = new Billet();
            //act
            int minint = minbillet.BilPrisUdenRabatStorebælt();
            //assert
            Assert.AreEqual(240, minint);
        }

        [TestMethod()]
        public void MCPrisUdenRabatStorebæltTest()
        {
            //arrange
            Billet minbillet = new Billet();
            //act
            int minint = minbillet.MCPrisUdenRabatStorebælt();
            //assert
            Assert.AreEqual(125, minint);
        }

        [TestMethod()]
        public void BilPrisUdenRabatØresundTest()
        {
            //arrange
            Billet minbillet = new Billet();
            //act
            int minint = minbillet.BilPrisUdenRabatØresund();
            //assert
            Assert.AreEqual(240, minint);
        }

        [TestMethod()]
        public void MCPrisUdenRabatØresundTest()
        {
            //arrange
            Billet minbillet = new Billet();
            //act
            int minint = minbillet.MCPrisUdenRabatØresund();
            //assert
            Assert.AreEqual(125, minint);
        }
    }
}