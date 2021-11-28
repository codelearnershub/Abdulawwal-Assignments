using System;

namespace number9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] elements = { 3, 7, 4, 6, 9, 11, 5 };
            Console.WriteLine($"the biggest number is {Biggest(elements)}");

        }

        public static int Biggest(int [] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int k = 0;
                for (int j = 1; j < array.Length; j++)
                {
                    if(array[j] > array[k])
                    {
                        int cont = array[j];
                        array[j] = array[k];
                        array[k] = cont;  
                    }
                    k++;
                }
                k = 0;
            }
            return array[0];
        }
    }
}
