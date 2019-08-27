using System;

namespace Ex1
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
                Int32 input1 = Input();
                Console.WriteLine("Введите второе число, затем Enter");
                Int32 input2 = Input();
                Console.WriteLine(input1 + " + " + input2 + " = " + (input1 + input2));
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }

        static Int32 Input()
        {
            while (true)
            {
                Int32 i;
                if (Int32.TryParse(Console.ReadLine(), out i))
                    return i;
                else
                {
                    Console.WriteLine("Ошибочное значение! Попробуйте ввести первое число еще раз, затем Enter");
                }
            }
        }
    }
}
