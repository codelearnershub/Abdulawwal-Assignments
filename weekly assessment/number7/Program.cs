using System;

namespace number7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter the numbers:");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int[] asd = Reverse(numbers);
            
            foreach (var item in asd)
            {
                Console.Write(item);
            }

        }

        public static int[] Reverse(int[] array)
        {
            int[] newNumbers = new int[array.Length];
            for (int i = array.Length - 1, j = 0; i >= 0; i--)
            {
                newNumbers[j] = array[i];
                j++;
            }
            return newNumbers;

        }
    }
}
