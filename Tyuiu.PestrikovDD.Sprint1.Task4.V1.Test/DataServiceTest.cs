using Tyuiu.PestrikovDD.Sprint1.Task4.V1.Lib;

namespace Tyuiu.PestrikovDD.Sprint1.Task4.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 5;
            Assert.AreEqual((Math.Round(1 / Math.Sqrt((x + 2)), 3)), ds.Calculate(x));

        }
    }
}
