using System;
using System.Diagnostics.CodeAnalysis;
using System.IO.MemoryMappedFiles;
using System.Reflection;

namespace HW04.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Alg();
            Algcontinue();
            Algcontin();
            Algcon();
        }
        static void Alg()
        {
            Console.WriteLine("First number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second number : ");
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = a + b;
            Console.WriteLine("Sum: " + sum);
            Console.ReadLine();

        }
        static void Algcontinue()
        {
            Console.WriteLine("First number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second number : ");
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = a + b;
            Console.WriteLine("Sum: " + sum);
            Console.ReadLine();

            if (sum == 10)
            {
                Console.WriteLine("Right!");
            }
            else
            {
                Console.WriteLine("Wrong");
            }
        }
        static void Algcontin()
        {
            Console.WriteLine("First number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second number : ");
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = a + b;
            Console.WriteLine("Sum: " + sum);
            Console.ReadLine();

            if (sum == 10)
            {
                Console.WriteLine("Right!");
            }
            else
            {
                Console.WriteLine("Wrong");
            }
            if (sum <= 10)
            {
                Console.WriteLine("Right!");
            }
            else
            {
                Console.WriteLine("Wrong");
            }
        }
        static void Algcon()
        {
            Console.WriteLine("First number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second number : ");
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = a + b;
            Console.WriteLine("Sum: " + sum);
            Console.ReadLine();

            if (sum == 10)
            {
                Console.WriteLine("Right!");
            }
            else
            {
                Console.WriteLine("Wrong");
            }
            if (sum <= 10)
            {
                Console.WriteLine("Right!");
            }
            else
            {
                Console.WriteLine("Wrong");
            }

        }
    }
}
