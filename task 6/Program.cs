using System;

namespace lesson1
{
    class Programm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 6. Программа осуществляет обмен значениями трех переменных величин a, b и c:");
            Console.WriteLine("Введите a");
            object a = Console.ReadLine();
            Console.WriteLine("Введите b");
            object b = Console.ReadLine();
            Console.WriteLine("Введите c");
            object c = Console.ReadLine();

            Console.WriteLine("Пункт а):\na = {0}\nb = {1}\nc = {2}", b, c, a);
            Console.WriteLine("Пункт b):\na = {0}\nb = {1}\nc = {2}", c, a, b);
        }
    }
}

