using System;
using System.Collections.Generic;

namespace num2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] qwe = { 1, 2, 3, 4 };
            Longest(qwe);
        }

        public static void Longest(int[] arr)
        {
            int count = 0;
            for (int i = 0; i <= arr.Length - 2; i++)
            {
                List<int> asd = new List<int>();
                for (int j = i + 1; j <= arr.Length - 1; j++)
                {
                    if (arr[j] - arr[i] == 1 || arr[j] - arr[i] == 0 || arr[i] - arr[j] == 1 || arr[i] - arr[j] == 0)
                    {
                        asd.Add(arr[j]);
                    }
                }

                if (asd.Count > count)
                {
                    count = asd.Count;
                }
            }
            if (arr.Length == count + 1)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(count + 1);
            }


        }
    }
}
