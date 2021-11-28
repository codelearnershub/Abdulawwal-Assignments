using System;

namespace number2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lengh of first array:");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("lengh of second array:");
            int n = int.Parse(Console.ReadLine());
            int[] array1 = new int[m];
            int[] array2 = new int[n];
            for (int i = 0; i < m; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }
            for (int j = 0; j < n; j++)
            {
                array2[j] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < m; i++)
            {
                if(m==n && array1[i] == array2[i])
                {
                    Console.WriteLine("They are equal");
                }
                else
                {
                    Console.WriteLine("They are not equal");
                }
            }
        }
    }
}
