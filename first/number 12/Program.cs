using System;

namespace Question_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Random nums = new Random();
            var firstNum = nums.Next(0, 100);
            var secondNum = nums.Next(0, 100);
            Console.WriteLine($"what is the sum of {firstNum} and {secondNum}:");
            int add = int.Parse(Console.ReadLine());
            if (add == firstNum + secondNum)
            {
                Console.WriteLine("You are correct!");
            }
            else
            {
                Console.WriteLine("You are wrong!");
            }
        }
    }
}
