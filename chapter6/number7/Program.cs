using System;

namespace number7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter figure for N:");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter figure for K:");
            int K = int.Parse(Console.ReadLine());
            int diff = N - K;

            int nFactorial = 1;
            int kFactorial = 1;
            int diffFactorial = 1;

            for (int i = N; i > 0; i--)
            {
                nFactorial = nFactorial * i;
            }

            for (int j = K; j > 0; j--)
            {
                kFactorial = kFactorial * j;
            }

            for (int l = diff; l > 0; l--)
            {
                diffFactorial = diffFactorial * l;
            }

            int solution = (nFactorial * kFactorial) / diffFactorial;
            Console.WriteLine(solution);
        }
    }
}
