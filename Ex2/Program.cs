using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                //Задание 2:
                //Ввести с консоли 2 числа: n и i. Вывести значение i-ого бита числа n
                Console.WriteLine();
            Console.WriteLine("Задание 2: Ввести с консоли 2 числа: n и i. Вывести значение i-ого бита числа n");
            Console.WriteLine("Введите число n, затем Enter");
            var n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите i - порядковый номер бита, который нужно вывести на экран, затем Enter");
            var i = Convert.ToInt32(Console.ReadLine());

            var binary = Convert.ToString(n, 2);
            var bit = (n >> i) & 1;
            Console.WriteLine("Число " + n + " в двоичной системе " + binary + " i бит (индексация справа с нуля) равен " + bit);
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
