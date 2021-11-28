using System;

namespace number4
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array1 = { 1, 2, 3, 4, 5 };
            int[] array2 = { 2, 5, 9 };
            int[] array3 = new int[array1.Length + array2.Length];
            

            for (int i = 0, j = 0; i < array3.Length; i++)
            {
                if (i < array1.Length)
                {
                    array3[i] = array1[i];
                }
                else if(i >= array1.Length)
                {
                    array3[i] = array2[j];
                    j++;
                }
            }

            Array.Sort(array3);

            foreach (var k in array3)
            {
                Console.Write($"{k} ");
            }
        }
    }
}
