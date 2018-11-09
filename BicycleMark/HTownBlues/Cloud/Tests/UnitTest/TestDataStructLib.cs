using DataStructLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructLib
{
    [TestClass]
    public class TestDataStructLib
    {
        [TestMethod]
        public void CreateEventDBContext()
        {
            using (var db = new EventDBContext())
            {
                db.Database.EnsureCreated();
                Assert.AreNotEqual(db, null);

            }
        }
        [TestMethod]
        public void RemoveEventDBContext()
        {
            using (var db = new EventDBContext())
            {
                db.Database.EnsureCreated();
                var t = db.Database.EnsureDeleted();
                Assert.AreEqual(t, true);

            }
        }
    }
}
