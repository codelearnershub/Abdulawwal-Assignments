using System;
using System.Numerics;

namespace num1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] asd = { 10, 2 };
            Largest(asd);
        }

        public static void Largest(int[] arr)
        {

            BigInteger max = 0;
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                BigInteger sum = arr[i];
                for (int j = i + 1; j <= arr.Length - 1; j++)
                {
                    int k = i;
                    i = j;
                    j = k;

                    sum += arr[j];
                    string a = "";
                    string b = arr[i].ToString();
                    a += b;
                    int current = int.Parse(a);
                    if (current > max)
                    {
                        max = current;
                    }
                }

            }
            Console.WriteLine(max);
        }
    }
}
