using System;

namespace Question_29
{
    class Program
    {
        static void Main(string[] args)
        {
           // int sum = 0;
           // int sum1 = 0;
            int tuition = 0;
            double tuitionRate = 0.05;
            double amount = 0;
           // int tuitionOnly = 0;
            int tuitionAmount = 10000;


            for(int i = 0; i < 10; i++)
            {
                tuition = tuition + tuitionAmount;
                amount = amount + (tuitionRate * tuition) + 10000;
                if(i == 4)
                {
                    Console.WriteLine($"The total cost of tuititon at the fourth year = {amount}");
                }

            }
            Console.WriteLine($"The tuition for 10 years = {amount}");
        }
    }
}
