using System;
using System.Collections.Generic;

namespace number_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] asd = new int[5];
            Console.WriteLine("Enter five integers");
            for (int i = 0; i < asd.Length; i++)
            {
                asd[i] = int.Parse(Console.ReadLine());
            }
            MiniMaxSum(asd);
        }

        public static void MiniMaxSum(int[] arr)
        {
            int[] max = new int[4];
            int[] min = new int[4];
            int maxSum = 0;
            int minSum = 0;
            Array.Sort(arr);
            for (int i = 1; i < 5; i++)
            {
                maxSum += arr[i];
            }
            for (int i = 0; i < 4; i++)
            {
                minSum += arr[i];
            }
            Console.WriteLine($"{minSum}  {maxSum}");
        }
    }
}