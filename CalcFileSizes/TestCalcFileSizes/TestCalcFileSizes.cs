using System;
using CalcFileSizes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestCalcFileSizes
{
    [TestClass]
    public class TestCalcFileSizes
    {
        [TestMethod]
        public void TestOpenWorkBook()
        {
            var wb = new WorkBook();
            var t = wb.OpenWorkBook(@"Summary.xlsx");

            Assert.AreEqual(t, true);
        }
        [TestMethod]
        public void TestOpenInvalidWorkBook()
        {
            var wb = new WorkBook();
            var t = wb.OpenWorkBook(@"..\..\Sum.xslx");
            Assert.AreEqual(t, false);
        }
    }
}
