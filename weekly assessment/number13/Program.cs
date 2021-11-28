using System;

namespace number13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int realNum = int.Parse(Console.ReadLine());

            string num = realNum.ToString();
            for (int i = num.Length - 1; i >= 0; i--)
            {
                Console.Write($"{num[i]}");
            }
        }
    }
}
