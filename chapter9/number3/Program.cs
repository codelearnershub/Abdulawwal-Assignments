using System;

namespace number3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int num = int.Parse(Console.ReadLine());

            English(num);
        }

        public static void English(int a)
        {
            int lastDigit = a % 10;
            Console.WriteLine($"for {a} -> {Words(lastDigit)}");
        }

        public static string Words(int num) => num switch
        {
            1 => "One",
            2 => "Two",
            3 => "Three",
            4 => "Four",
            5 => "Five",
            6 => "Six",
            7 => "Seven",
            8 => "Eight",
            9 => "Nine",
            0 => "Zero",
            _ => null
        };
    }
}
