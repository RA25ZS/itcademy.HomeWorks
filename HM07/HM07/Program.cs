using System;

namespace HM07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter: ");
            string phrase = Console.ReadLine();
            phrase = phrase.Replace("o", "a");
            string[] words = phrase.Split(' ');
            foreach (var word in words)
            {
                Console.WriteLine($"{word};");
            }
            Console.ReadLine();
        }
    }
}
