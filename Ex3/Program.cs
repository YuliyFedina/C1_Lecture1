using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                //Задание 3:
                // Ввести с консоли число. Обнулить последний бит этого числа. Вывести на консоль
                Console.WriteLine();
                Console.WriteLine("Задание 3:  Ввести с консоли число. Обнулить последний бит этого числа. Вывести на консоль");
                Console.WriteLine("Введите число, затем Enter");
                var number = Convert.ToInt32(Console.ReadLine());

                var binary2 = Convert.ToString(number, 2);
                var m = (1 << 31);
                //Console.WriteLine(Convert.ToString(m, 2));
                while ((number & m) == 0)
                {
                    m >>= 1;
                }
                //Console.WriteLine(Convert.ToString(m, 2));

                var newnumber = number ^ (m & number);

                Console.WriteLine("Число " + number + " в двоичной системе " + binary2 + " если обнулить последний бит этого числа (индексация справа с нуля) получим " + newnumber);

            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
