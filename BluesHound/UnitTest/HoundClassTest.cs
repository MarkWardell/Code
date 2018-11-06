using ContentLib;
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
        //[TestMethod]
        //public async Task TestGrabCalendarUriAsFile()
        //{
        //    //Arrange 
        //    string testCalendarLocation = @"Data\\TheBluesHound.html";
        //    string str = String.Empty;
        //    if (File.Exists(testCalendarLocation))
        //    {
        //        ICalendarSite su = new CalendarFromFile();
        //        str = await su.GrabCalendar(testCalendarLocation);
        //    }
           
           
            
        //    //Assert
        //    Assert.AreNotEqual(string.Empty,str);
        //}

        //[TestMethod]
        //public async Task TestGrabCalendarUrifromWeb()
        //{
        //    //Arrange 

        //    ICalendarSite surl = new CalendarFromWeb();
        //    string str = await surl.GrabCalendar("https://theblueshound.com/music-calendar");
            
        //    //Assert
        //    Assert.AreNotEqual(String.Empty, str);
        //}

        [TestMethod]
        public async Task TestWebstiteGrabberFromWeb()
        {
            //Arrange 

            ItemFromUrl iturl = new ItemFromUrl("https://theblueshound.com/music-calendar");
            WebStiteGrabber wg = new WebStiteGrabber(iturl);
            string str = await wg.GrabAsync();



            //Assert
            Assert.AreNotEqual(String.Empty, str);
        }
        [TestMethod]
        public async Task TestWebstiteGrabberFromFile()
        {
            //Arrange 

            ItemFromFile iturl = new ItemFromFile( @"Data\\TheBluesHound.html");
            WebStiteGrabber wg = new WebStiteGrabber(iturl);
            string str = await wg.GrabAsync();



            //Assert
            Assert.AreNotEqual(String.Empty, str);
        }
    }
}
