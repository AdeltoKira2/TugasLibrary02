using System;
using TugasLibrary;
using NUnit.Framework;

namespace TugasLibraryUnitTest
{
    [TestFixture]
    public class TugasLibraryTest
    {
        private Day hari;
        private User pengguna;
        [SetUp]
        public void init()
        {
            hari = new Day();
            pengguna = new User();
        }
        [Test]
        public void NameOfTheDayTest()
        {
            Assert.AreEqual("Senin", hari.NameOfDay(1));
            Assert.AreEqual("Selasa", hari.NameOfDay(2));
            Assert.AreEqual("Rabu", hari.NameOfDay(3));
            Assert.AreEqual("Kamis", hari.NameOfDay(4));
            Assert.AreEqual("Jum'at", hari.NameOfDay(5));
            Assert.AreEqual("Sabtu", hari.NameOfDay(6));
            Assert.AreEqual("Minggu", hari.NameOfDay(7));
        }
        [Test]
        public void TestUserValid()
        {
            Assert.IsTrue(pengguna.IsValidUser("admin", "admin"));
        }
    }
}
