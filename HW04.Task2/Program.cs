using System;
using System.Diagnostics.CodeAnalysis;

namespace HW04.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b = 0;
            Console.WriteLine("Введите первое число:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Сумма равна:{0}", a + b);
            Console.ReadKey();

            int sum = a + b;
            if (sum == 15)
            {
                string message = "Right!";
                Console.WriteLine(message);
            }
        }
                
    } 
}
