﻿using System;
 
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int d = 0;
            for (char i = 'z'; i >= 'a'; i--)
            {
                Console.Write(d % 5 == 0 && d!=0 ? $"\n{i} " : $"{i} ");
                d--;
            }
            Console.ReadKey(true);
        }
    }
}