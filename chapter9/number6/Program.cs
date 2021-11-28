using System;
using System.Collections.Generic;

namespace number6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 4, 2, 3, 8, 4, 8, -6, 3, 1 };
            int x = Position(numbers);
            Console.WriteLine($"the first occurence is at index {x}");
        }


        public static int Position(int[] array)
        {
            List<int> positions = new List<int>();

            for (int i = 1; i < array.Length-1; i++)
            {
                if(array[i] > array[i+1] && array[i] > array[i - 1])
                {
                    positions.Add(i);
                }

            }
            return positions[0];
        }
    }
}
