using System;

namespace Question_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the investment amount");
            int investmentAmount = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the annual interest rate");
            int annualInterestRate = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of years");
            int numberOfYears = int.Parse(Console.ReadLine());
            int futureInvestmentValue = investmentAmount * (1 + annualInterestRate) ^ numberOfYears * 12;
            Console.WriteLine($"the future investment value is {futureInvestmentValue}");
        }
    }
}
