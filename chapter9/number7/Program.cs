using System;

namespace number7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int number = int.Parse(Console.ReadLine());

            Reversed(number);
        }

        public static void Reversed(int num)
        {
            string a = num.ToString();
            for (int i = a.Length - 1; i >= 0; i--)
            {
                Console.Write($"{a[i]}");
            }
        }
    }
}
