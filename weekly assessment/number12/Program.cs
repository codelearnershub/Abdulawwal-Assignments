using System;

namespace number12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{IsPrime(9)}");
            for (int i = 1; i <= 10000; i++)
            {
                if (IsPrime(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static bool IsPrime(int num)
        {
            bool isPrime = true;
            int count = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }
            if (count != 2)
            {
                isPrime = false;
            }

            return isPrime;
        }
    }
}
