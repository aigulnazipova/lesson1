using System;
using System.Globalization;

namespace lesson1
{
    class Programm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 2:");

            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            };

            Console.WriteLine("Введите число 1");
            string num1 = Console.ReadLine();
            int a;
            bool result1 = int.TryParse(num1, out a);
            Console.WriteLine("Введите число 2");
            string num2 = Console.ReadLine();
            int b;
            bool result2 = int.TryParse(num2, out b);

            if (result1 && result2)
            {
                Console.WriteLine("Ответ: {1}{0}", a, b);
            }
            else
            {
                Console.WriteLine("Ошибка! Введите числовые значения");
            }



        }
    }
}
