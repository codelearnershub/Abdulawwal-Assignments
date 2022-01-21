using System;
using System.Collections.Generic;

namespace num1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stair(8);
        }

        public static void Stair(int n)
        {
            List<int> asd = new List<int>();

            for (int i = 1, j = 1; j <= n; i++, j += i)
            {
                asd.Add(j);

            }
            Console.WriteLine(asd.Count);
        }
    }
}
