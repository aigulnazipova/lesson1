using System;

namespace lesson1
{
    class Programm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 3. Программа вычисляет длину окружности и площадь круга по заданному значению радиуса");
            Console.WriteLine("Введите радиус окружности:");
            double radius;
            if (double.TryParse(Console.ReadLine(), out radius))
            {
                double circumference = 2 * Math.PI * radius;
                double AreaCircle = Math.PI * Math.Pow(radius, 2);
                Console.WriteLine("Длина окружности = {0}\nПлощадь круга = {1}", circumference, AreaCircle);
            }
            else
            {
                Console.WriteLine("Введено недопустимое значение, введите числовое значение");
            }
        }
    }
}
