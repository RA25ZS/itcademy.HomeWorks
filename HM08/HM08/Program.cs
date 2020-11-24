using System;
using System.Text;

namespace HM08
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
        }
        static void Task1()
        {
            StringBuilder sb = new StringBuilder("1a!2.3!!.. 4.!.?6 7! ..?");
            sb.Replace(".", "!");
            sb.Replace("!", ".");
            sb.Replace(" ", ".");
            sb.Replace(".", "_");
            Console.WriteLine(sb);
        }

        static void Task2()
        {
            Console.WriteLine("gdfgdf234dg54gf*23oP42");
            int num1 = 23454;
            int num2 = 2342;
            int final = num1 * num2;
            Console.WriteLine(final);
        }
    }
}
