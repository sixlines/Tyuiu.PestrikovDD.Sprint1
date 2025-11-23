using Tyuiu.PestrikovDD.Sprint1.Task3.V13.Lib;
namespace Tyuiu.PestrikovDD.Sprint1.Task3.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 453;
            double a = (int)(x / 100);
            double b = (int)((x % 100) / 10);
            double c = (int)x % 10;
            int wait = 60;
            var res = ds.MultiplyOfDigits(x);
            Assert.AreEqual(wait, res);
        }
    }
}
