using Tyuiu.BaturinaSA.Sprint2.Task6.V6.Lib;

namespace Tyuiu.BaturinaSA.Sprint2.Task6.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindCardNameAndValue()
        {
            DataService ds = new DataService();
            int m = 1;
            int k = 12;
            string res = ds.FindCardNameAndValue(m, k);
            string wait = "Дама пик";

            Assert.AreEqual(wait, res);
        }
    }
}