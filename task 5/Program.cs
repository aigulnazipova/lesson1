using System;

namespace lesson1
{
    class Programm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 5. Программа считает корни квадратного уравнения по заданным коэффициентам");
            double x1, x2, X, a, b, c, d;
            Console.WriteLine("Введите a");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите b");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите c");
            c = Convert.ToDouble(Console.ReadLine());

            d = b * b - 4 * a * c;

            if (d < 0)
            {
                Console.WriteLine("Нет корней");
            }

            if (d == 0)
            {
                X = -b / (2 * a);
                Console.WriteLine("x={0}", X);
            }

            if (d > 0)
            {
                x1 = (-b + Math.Pow(d, 0.5)) / (2 * a);
                x2 = (-b - Math.Pow(d, 0.5)) / (2 * a);
                Console.WriteLine("x1={0}; x2={1}", x1, x2);
            }
        }
    }
}

