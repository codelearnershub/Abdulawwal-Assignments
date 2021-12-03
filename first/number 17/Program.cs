using System;

namespace Question_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Years       Anticipated World Population    Numerical Increase In World Population");

            double anticipatedWorldPopulation = 0;
            double growthRate = 0.75;
            double population = 23000 * 2;
            int x = 0;

            for(int i = 1; i <= 75; i++)
            {
                anticipatedWorldPopulation = anticipatedWorldPopulation  + 23000;
               double numberIncrease = growthRate * anticipatedWorldPopulation;
               double numericalWorldPopulation = anticipatedWorldPopulation + numberIncrease;

                Console.WriteLine($"{i}     {anticipatedWorldPopulation}        { numericalWorldPopulation}");
                
                if(population == anticipatedWorldPopulation)
                {
                    x = i;
                }
            }

            Console.WriteLine($"The world population is doubled at {x}nd years");
        }
    }
}
