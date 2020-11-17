using System;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "!yad taerg evaH";
            char[] charArray = message.ToCharArray();
            Array.Reverse(charArray);

            foreach (char messageChar in charArray)
            {
                Console.Write(messageChar);
            }
            Console.ReadLine();
        }
    }
}
