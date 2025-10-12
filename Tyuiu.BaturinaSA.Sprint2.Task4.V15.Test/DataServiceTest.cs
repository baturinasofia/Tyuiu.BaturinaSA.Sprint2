using Tyuiu.BaturinaSA.Sprint2.Task4.V15.Lib;

namespace Tyuiu.BaturinaSA.Sprint2.Task4.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 4;
            double res = ds.Calculate(x, y);
            double wait = 3.125;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 625;
            double res = ds.Calculate(x, y);
            double wait = -0.234;
            Assert.AreEqual(wait, res);
        }
    }
}