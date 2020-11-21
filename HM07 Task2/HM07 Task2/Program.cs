using System;

namespace HM07_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            First();
            Second();
            Third();
        }
        static void First ()
        {
            Console.WriteLine("Enter: ");
            string str = Console.ReadLine();
            string[] ss = str.Split(' ');

            int temp = 0;
            int min = ss[0].Length;

            for (int i = 0; i < ss.Length; i++)
                if (min < ss[i].Length) { min = ss[i].Length; temp = i; }

            for (int i = 0; i < ss.Length; i++)
                if (i != temp) Console.Write("{0} ", ss[i]);

            Console.ReadKey();
        }
        static void Second ()
        {
            Console.WriteLine("Enter: ");
            string input = Console.ReadLine();
            int ind = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input.Substring(i, 1) != " ")
                    ind++;
            }
            Console.WriteLine("Ammount= {0}", ind);
            Console.ReadKey();
        }
        static void Third ()
        {
            Console.WriteLine("Enter: ");
            string str = Console.ReadLine();
            string[] ss = str.Split(' ');
        }
    }
}
