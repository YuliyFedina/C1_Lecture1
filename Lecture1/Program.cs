using System;

namespace Lecture1
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Введите первое число");
                int input1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе число");
                int input2 = Convert.ToInt32(Console.ReadLine());
                try
                {
                    int result = input1 + input2;
                    Console.WriteLine(input1 + " + " + input2 + " = " + result);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
