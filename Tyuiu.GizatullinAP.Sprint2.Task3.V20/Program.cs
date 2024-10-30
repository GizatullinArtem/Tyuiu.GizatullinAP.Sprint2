using Tyuiu.GizatullinAP.Sprint2.Task3.V20.Lib;
namespace Tyuiu.GizatullinAP.Sprint2.Task3.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 Выполнил: Гизатуллин А. П. | ИСПб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: #2.2 Операции сравнения                                           *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Варинат #3                                                              *");
            Console.WriteLine("* Выполнил: Гизатуллин Артём Павлович ИСПб-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу,которая вычесляет которая вернет                     *");
            Console.WriteLine("* логическую последовательность и печатает результат на экране.           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите значение переменной X: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double res = ds.Calculate(x);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Значение функции =" + Math.Round(res, 3));
            Console.ReadKey();



        }

    }
}