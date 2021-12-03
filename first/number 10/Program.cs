using System;

namespace Question_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your monthly savings amount:");
            int monthlySavings = int.Parse(Console.ReadLine());
            double annualInterestRate = 0.00417;
            double amount = 0;
            int i = 0;
            

            while(i < 6)
            {
                amount = amount + monthlySavings * (1 + annualInterestRate);
                i++;
            }
            Console.WriteLine($"The account value after six month is {amount}");
        }
    }
}
