using System;

namespace number11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value of N");
            int N = int.Parse(Console.ReadLine());
            long factorial = 1;
            for (int i = N; i > 1; i--)
            {
                factorial = factorial * i;
            }

            char[] f = factorial.ToString().ToCharArray();
            int count = 0;
            for (int j = f.Length - 1; j >= 0; j--)
            {
                if (f[j] == '0')
                {
                    count++;
                }

                else if (f[j] != '0')
                {
                    break;
                }

            }
            Console.WriteLine(factorial);
            Console.WriteLine(count);

        }
    }
}
