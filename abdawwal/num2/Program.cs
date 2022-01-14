using System;
using System.Collections.Generic;

namespace num2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {7,7,7,7 };
            Sub(nums);
        }

        public static void Sub(int[] arr)
        {
            List<int> asd = new List<int>();
            for (int i = 0; i <= arr.Length - 2; i++)
            {
                if (arr[i] < arr[i + 1])
                {
                    asd.Add(arr[i]);
                }
            }
            Console.WriteLine(asd.Count + 1);
        }
    }
}
