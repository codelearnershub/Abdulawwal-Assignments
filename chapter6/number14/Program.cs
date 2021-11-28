using System;

namespace number14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number in decimal notation: ");
            int num = int.Parse(Console.ReadLine());

            string hex = "";

            int val = num / 16;
            hex += val;

            int rem = num % 16;

            if (rem > 9)
            {
                hex += (Char(rem)).ToString();

            }
            Console.WriteLine(hex);
        }

        public static char? Char(int fig) => fig switch
        {
            10 => 'A',
            11 => 'B',
            12 => 'C',
            13 => 'D',
            14 => 'E',
            15 => 'F',
            _ => null

        };
    }
}
