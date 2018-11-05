using HoundUtil;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Threading.Tasks;

namespace UnitTest
{
    [TestClass]
    public class HoundClassTest
    {
        [TestMethod]
        public async Task TestGrabCalendarUriAsFile()
        {
            //Arrange 
            string testCalendarLocation = @"Data\\TheBluesHound.html";
            string str = String.Empty;
            if (File.Exists(testCalendarLocation))
            {
                ISiteUtil su = new SiteUtilFromFile();
                str = await su.GrabCalendar(testCalendarLocation);
            }
           
           
            
            //Assert
            Assert.AreNotEqual(string.Empty,str);
        }

        [TestMethod]
        public async Task TestGrabCalendarUrifromWeb()
        {
            //Arrange 

            ISiteUtil surl = new SiteUtilFromWeb();
            string str = await surl.GrabCalendar("https://theblueshound.com/music-calendar");
            
            //Assert
            Assert.AreNotEqual(String.Empty, str);
        }
    }
}
