using System;

namespace number5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {9,5,3,6,7,-5, 5,8,9,3 };
            Console.WriteLine("Enter the index of the element:");
            int index = int.Parse(Console.ReadLine());

            if(index != 0 || index != numbers.Length-1)
            {
                if (IsGreater(numbers, index) == true)
                {
                    Console.WriteLine("The element is greater than its neighbors");
                }
                else
                {
                    Console.WriteLine("The element is  not greater than its neighbors");
                }
            }
            else if (index == 0 || index == numbers.Length - 1)
            {
                Console.WriteLine("your choice has just a neighbor");
            }

        }

        public static bool IsGreater(int [] array, int postion)
        {
            bool flag = false;
            for (int i = 1; i < array.Length -1; i ++)
            {
                if(array[postion] > array[postion + 1] && array[i] > array[postion - 1])
                {
                    flag = true;
                }
            }
            return flag;
        }
    }
}
