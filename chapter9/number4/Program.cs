using System;

namespace number4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = { 1, 1, 2, 3, 2, 2, 2, 1 };
            Console.WriteLine("Enter the number:");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine($"{num} occured {Repitition(sequence, num)} times");
        }

        public static int Repitition(int[] array, int element)
        {
            int count = 0;
            foreach (var item in array)
            {
                if (item == element)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
