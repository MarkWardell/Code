using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace ParserLib
{
    [TestClass]
    public class TestParserLib
    {
       
       
        [TestMethod]
        public async Task TestLib()
        {
            //Arrange 
            await Task.Delay(10);
            Assert.AreEqual(1, 1);
        }
      
    }
}
