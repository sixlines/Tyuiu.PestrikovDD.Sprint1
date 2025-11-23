using Tyuiu.PestrikovDD.Sprint1.Task6.V16.Lib;
namespace Tyuiu.PestrikovDD.Sprint1.Task6.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Пестриков Д. Д. | ИСТНБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Cпринт #1                                                               *");
            Console.WriteLine("* Тема: Работа со строками класс String                                   *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Пестриков Данила Дмитриевич | ИСТНБ-25-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу: пользователь вводит текст. Проверить, что в строке  *");
            Console.WriteLine("* есть восклицание (!) и вопрос (?).                                      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите текст для проверки наличия ! и ?:");
            string textcheck = Console.ReadLine();
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
            DataService ds = new DataService();
            Console.WriteLine(ds.CheckSpecSymbols(textcheck));
            Console.ReadKey();
        }
    }
}