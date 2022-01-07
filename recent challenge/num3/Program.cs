using System;

namespace num3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static void Robot()
        {
            Console.Write("enter value for m: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("enter value for n: ");
            int n = int.Parse(Console.ReadLine());

            int[,]  abc = new int[m, n];
            int a = m + n;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    if(j == n-1)
                    {

                    }
                }
            }


        }
    }
}
