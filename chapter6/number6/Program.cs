using System;

namespace number6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter figure for N:");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter figure for K:");
            int K = int.Parse(Console.ReadLine());

            int nFactorial = 1;
            int kFactorial = 1;

            for (int i = N; i > 0; i--)
            {
                nFactorial = nFactorial * i;
            }

            for (int j = K; j > 0; j--)
            {
                kFactorial = kFactorial * j;
            }

            int solution = nFactorial / kFactorial;
            Console.WriteLine(solution);


        }
    }
}
