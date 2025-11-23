using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PestrikovDD.Sprint1.Task1.V29.Lib;

namespace Tyuiu.PestrikovDD.Sprint1.Task1.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 2.0;
            double c = 3.0;
            var res = ds.Calculate(x, y, c);
            Assert.AreEqual(1, res);
        }
    }
}
