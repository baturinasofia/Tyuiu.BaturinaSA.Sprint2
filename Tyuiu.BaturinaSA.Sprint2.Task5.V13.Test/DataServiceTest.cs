using Tyuiu.BaturinaSA.Sprint2.Task5.V13.Lib;

namespace Tyuiu.BaturinaSA.Sprint2.Task5.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestEndOfMonth()
        {
            var ds = new DataService();
            string result = ds.FindDateOfNextDay(2021, 3, 31);
            Assert.AreEqual("01.04.2021", result);
        }

        [TestMethod]
        public void TestMiddleOfMonth()
        {
            var ds = new DataService();
            string result = ds.FindDateOfNextDay(2015, 11, 23);
            Assert.AreEqual("24.11.2015", result);
        }

        [TestMethod]
        public void TestEndOfYear()
        {
            var ds = new DataService();
            string result = ds.FindDateOfNextDay(2025, 12, 31);
            Assert.AreEqual("01.01.2026", result);
        }
    }
}