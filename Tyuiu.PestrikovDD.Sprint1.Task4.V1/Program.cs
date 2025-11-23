using Tyuiu.PestrikovDD.Sprint1.Task4.V1.Lib;
namespace Tyuiu.PestrikovDD.Sprint1.Task4.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Пестриков Д. Д.  | ИСТНБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Class math C#                                                     *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Пестриков Данила Дмитриевич | ИСТНБ-25-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* вычисляет результат по формуле и печатает его на экране                 *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:     x (вещ. число)                                     *");
            Console.WriteLine("*         1                                                               *");
            Console.WriteLine("*      -------                                                            *");
            Console.WriteLine("*      (x+2)^2                                                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:      Расстояние в км.    (вещественное число)                *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(ds.Calculate(x));

        }
    }
}