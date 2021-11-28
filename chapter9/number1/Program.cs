using System;

namespace number1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name:");
            string name = Console.ReadLine();
            PrintName(name);
        }

        public static void PrintName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
