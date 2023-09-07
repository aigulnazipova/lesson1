using System;

namespace lesson1
{
    class Programm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 9. ");
            Console.WriteLine("Введите цену одного килограмма конфет:");
            int sweets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество килограмм:");
            int weight = Convert.ToInt32(Console.ReadLine());
            int price_sweets = sweets * weight;
            Console.WriteLine("Введите цену одного килограмма печенья:");
            int cookies = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество килограмм:");
            int weight1 = Convert.ToInt32(Console.ReadLine());
            int price_cookies = cookies * weight1;
            Console.WriteLine("Введите цену одного килограмма яблок:");
            int apples = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество килограмм:");
            int weight2 = Convert.ToInt32(Console.ReadLine());
            int price_apples = apples * weight2;
            int total_price = price_sweets + price_cookies + price_apples;
            Console.WriteLine("Сумма покупки = {0}", total_price);
        }
    }
}
