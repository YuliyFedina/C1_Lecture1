using System;

namespace Lecture1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1:
            //Ввести с консоли 2 числа. Вывести их сумму на консоль
            do
            {
                Console.WriteLine("Задание 1: Ввести с консоли 2 числа. Вывести их сумму на консоль");
                Console.WriteLine("Введите первое число, затем Enter");
                var input1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите второе число, затем Enter");
                var input2 = Convert.ToInt32(Console.ReadLine());
                try
                {
                    var result = input1 + input2;
                    Console.WriteLine(input1 + " + " + input2 + " = " + result);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

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

                //Задание 3:
                // Ввести с консоли число. Обнулить последний бит этого числа. Вывести на консоль
                Console.WriteLine();
                Console.WriteLine("Задание 3:  Ввести с консоли число. Обнулить последний бит этого числа. Вывести на консоль");
                Console.WriteLine("Введите число, затем Enter");
                var number = Convert.ToInt32(Console.ReadLine());

                var binary2 = Convert.ToString(number, 2);
                var m = (1 << 31);
                Console.WriteLine(Convert.ToString(m, 2));
                while ((number & m) == 0)
                {
                    m >>= 1;
                }
                Console.WriteLine(Convert.ToString(m, 2));

                var newnumber = number ^ (m & number);

                Console.WriteLine("Число " + number + " в двоичной системе " + binary2 + " если обнулить последний бит этого числа (индексация справа с нуля) получим " + newnumber);

            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
