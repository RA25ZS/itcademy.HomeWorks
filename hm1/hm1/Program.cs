using System;

namespace hm1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random();
            Numenter();
            SumNumbers();

            static void Random()
            {
            int[] rannumb = new int[5];
            Random rand = new Random();
            for (int i = 0; i < rannumb.Length; i++)
            {
                rannumb[i] = rand.Next();
                Console.WriteLine(rannumb[i]);
            }
            Console.ReadLine();
            }
        }
        static void Numenter()
        {
            int[] enter = new int[5];
            for (int i = 0; i < enter.Length; i++)
            {
                Console.WriteLine(i);
                enter[i] = int.Parse(Console.ReadLine());
            }
        }
        static void SumNumbers()
        {
            int[] array1 = new int[] {1, 2, 3, 4, 5};
            int sum = array1[0] + array1[1];
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("Sum:" + sum);
            }
            Console.ReadLine();
        }
    }
}
