using Tyuiu.BaturinaSA.Sprint2.Task1.V8.Lib;

namespace Tyuiu.BaturinaSA.Sprint2.Task1.V8;
internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        int x = 15;
        int y = 16;
        int c = 14;
        int d = 335;
        bool[] res = new bool[6];
        res = ds.GetLogicOperations(x, y, c, d);
        Console.Title = "Спринт #2 | Выполнил: Батурина С. А. | ИСТНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Логические операции                                               *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #8                                                              *");
        Console.WriteLine("* Выполнил: Батурина Софья Алексеевна | ИСТНб-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=)         *");
        Console.WriteLine("* и логических операций (|, &, ||, &&, !, ^)                              *");
        Console.WriteLine("* а также арифметических выражений, которая вернет логическую             *");
        Console.WriteLine("* последовательность(массив): (True,False,True,False,False,False)         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("X = " + x);
        Console.WriteLine("Y = " + y);
        Console.WriteLine("C = " + c);
        Console.WriteLine("D = " + d);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        for (int i = 0; i < res.Length; i++)
            Console.WriteLine(res[i]);
        Console.ReadKey();
    }
}