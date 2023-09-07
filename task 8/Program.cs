using System;

namespace lesson1
{
    class Programm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 8.");
            Console.WriteLine("Введите любое трехзначное число");
            string n = Console.ReadLine();
            Console.WriteLine("Ответ: {0}{1}{2}", n[2], n[0], n[1]);
        }
    }
}

