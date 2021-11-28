using System;

namespace number20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value for c1:");
            int c1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter value for c2:");
            int c2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number per line:");
            int n = int.Parse(Console.ReadLine());

            PrintChars(c1, c2, n);
        }

        public static void PrintChars(int c1, int c2, int numberPerLine)
        {

            int[] asd = new int[c2 - c1];
            for (int i = c1, j = 0; i < c2; i++)
            {
                asd[j] = i;
                j++;
            }

            for (int k = 0; k < asd.Length; k++)
            {
                Console.Write($"{asd[k]} ");
                if ((k + 1) % numberPerLine == 0)
                {
                    Console.WriteLine();
                }
            }
        }

        static int? GetNumber(char cha) => cha switch
        {
            'A' => 1,
            'B' => 2,
            'C' => 3,
            'D' => 4,
            'E' => 5,
            'F' => 6,
            'G' => 7,
            'H' => 8,
            'I' => 9,
            'J' => 10,
            'K' => 11,
            'L' => 12,
            'M' => 13,
            'N' => 14,
            'O' => 15,
            'P' => 16,
            'Q' => 17,
            'R' => 18,
            'S' => 19,
            'T' => 20,
            'U' => 21,
            'V' => 22,
            'W' => 23,
            'X' => 24,
            'Y' => 25,
            'Z' => 26,
            _ => null,
        };
    }
}
