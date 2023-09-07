using System;

namespace lesson1
{
    class Programm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 7. Программа выводит на консоль четыре случайных числа. ");
            Random rnd = new Random();
            int value1 = rnd.Next();
            int value2 = rnd.Next();
            int value3 = rnd.Next();
            int value4 = rnd.Next();
            Console.WriteLine("{0}\n{1}\n{2}\n{3}", value1, value2, value3, value4);
        }
    }
}


