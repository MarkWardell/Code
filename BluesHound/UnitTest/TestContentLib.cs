using ContentLib;
using ContentLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Threading.Tasks;

namespace UnitTest
{
    [TestClass]
    public class TestContentLib
    {
       
        [TestMethod]
        public async Task TestWebstiteGrabberFromWeb()
        {
            //Arrange 
            HtmlItem iturl = HtmlItemFactory.GetHtmlItem(Constants.LocationType.WEB, "https://theblueshound.com/music-calendar");
            WebStiteGrabber wg = new WebStiteGrabber(iturl);
            string str = await wg.GrabAsync();

            //Assert
            Assert.AreNotEqual(String.Empty, str);
        }
        [TestMethod]
        public async Task TestWebstiteGrabberFromFile()
        {
            //Arrange 

            HtmlItem iturl = HtmlItemFactory.GetHtmlItem(Constants.LocationType.FILE, @"Data\\TheBluesHound.html");
            WebStiteGrabber wg = new WebStiteGrabber(iturl);
            string str = await wg.GrabAsync();

            //Assert
            Assert.AreNotEqual(String.Empty, str);
        }
    }
}
