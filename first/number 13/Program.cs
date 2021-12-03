using System;

namespace Question_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your balance: ");
            double bal = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your annual interest rate");
            double annualInterestRate = double.Parse(Console.ReadLine());

            double interest = 0;
            int i = 0;

            do
            {
                interest = bal * (annualInterestRate/1200);
                i++;
            }while(i < 1);
            Console.WriteLine($"The interest for the next month is {interest}");
        }
    }
}
