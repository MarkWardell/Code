using ContentLib;
using DataStructLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;

namespace ContentLib
{
    [TestClass]
    public class TestContentLib
    {
       
       
        [TestMethod]
        public async Task TestEventGrabberFromWeb()
        {
            //Arrange 
            HtmlItem iturl = HtmlItemFactory.GetHtmlItem(ContentLib.Constants.LocationType.WEB, "https://theblueshound.com/music-calendar");
            WebStiteGrabber wg = new WebStiteGrabber(iturl);
            string str = await wg.GrabAsync();

            //Assert
            Assert.AreNotEqual(String.Empty, str);
        }
        [TestMethod]
        public async Task TestVenueGrabberFromWeb()
        {
            //Arrange 
            HtmlItem iturl = HtmlItemFactory.GetHtmlItem(ContentLib.Constants.LocationType.WEB, "https://theblueshound.com/venue-listing");
            WebStiteGrabber wg = new WebStiteGrabber(iturl);
            string str = await wg.GrabAsync();

            //Assert
            Assert.AreNotEqual(String.Empty, str);
        }
        
        [TestMethod]
        public async Task TestEventGrabberFromFile()
        {
      

            HtmlItem iturl = HtmlItemFactory.GetHtmlItem(ContentLib.Constants.LocationType.FILE, @"Data\\Events.html");
            WebStiteGrabber wg = new WebStiteGrabber(iturl);
            string str = await wg.GrabAsync();

            //Assert
            Assert.AreNotEqual(String.Empty, str);
        }

        [TestMethod]
        public async Task TestVenueGrabberFromFile()
        {
            //Arrange 

            HtmlItem iturl = HtmlItemFactory.GetHtmlItem(ContentLib.Constants.LocationType.FILE, @"Data\\Venues.html");
            WebStiteGrabber wg = new WebStiteGrabber(iturl);
            string str = await wg.GrabAsync();

            //Assert
            Assert.AreNotEqual(String.Empty, str);
        }
    }
}
