using System;

namespace number3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random();
        }
        public static void Random()
        {
            char[] letters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            Random letter = new Random();
            int num = letter.Next(0, 27);
            Console.WriteLine(num);
            Console.WriteLine($"{letters[num]}");
        }
    }
}
