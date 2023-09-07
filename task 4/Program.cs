using System;

namespace lesson1
{
    class Programm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 4. Программа считает значение y=cos(x) по заданному значению х");
            Console.WriteLine("Введите значение х");
            double y;
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(y = (double)Math.Cos(x));
        }
    }
}
