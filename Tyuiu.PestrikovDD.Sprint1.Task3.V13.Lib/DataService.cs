using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.PestrikovDD.Sprint1.Task3.V13.Lib
{
    public class DataService : ISprint1Task3V13
    {
        public double MultiplyOfDigits(double x)
        {
            double a = (int)(x / 100);
            double b = (int)(x % 100 / 10);
            double c = (int)(x % 10);
            return a * b * c;
        }
    }
}
