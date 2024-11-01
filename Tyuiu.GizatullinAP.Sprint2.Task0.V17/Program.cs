﻿using Tyuiu.GizatullinAP.Sprint2.Task0.V17.Lib;
using Tyuiu.GizatullinAP.Sprint2.Task0.V17.Lib;
namespace Tyuiu.GizatullinAP.Sprint2.Task0.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Гизатуллин А. П. | ИCПб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Операции сравнения                                                      *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Гизатуллин Артём Павлович | ИИПБ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*Написать программу из операций сравнений и арифметических выражений, кото*");
            Console.WriteLine("*орая вернет логическую последовательность.                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("x = 1065, y = 755");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            DataService ds = new DataService();
            var results = ds.GetCompareOperations(1065, 755);
            Console.WriteLine(String.Join(", ", results));
            Console.ReadKey();
        }
    }
}