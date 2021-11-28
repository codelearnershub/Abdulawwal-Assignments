using System;

namespace number8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter figure for n:");
            int n = int.Parse(Console.ReadLine());

            int numerator = 2 * n;
            int denominator = n + 1;


            int nFactorial = 1;
            int numeratorFactorial = 1;
            int denominatorFactorial = 1;

            for (int i = n; i > 0; i--)
            {
                nFactorial = nFactorial * i;
            }

            for (int j = numerator; j > 0; j--)
            {
                numeratorFactorial = numeratorFactorial * j;
            }

            for (int l = denominator; l > 0; l--)
            {
                denominatorFactorial = denominatorFactorial * l;
            }


            int solution = numeratorFactorial / (denominatorFactorial * nFactorial);
            Console.WriteLine(solution);
        }
    }
}
