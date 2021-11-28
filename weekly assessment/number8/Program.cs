using System;

namespace number8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("how many numbers:");
            int n = int.Parse(Console.ReadLine());

            int[] asd = new int[n];
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("enter the elements:");
                int element = int.Parse(Console.ReadLine());
                if (EliminateDuplicate(asd, element) == true)
                {
                    asd[count] = element;
                    count++;
                }
            }

            for (int k = 0; k < count; k++)
            {
                Console.Write($"The distinct numbers are : {asd[k]} ");
            }


        }

        public static bool EliminateDuplicate(int[] list, int element)
        {
            bool flag = true;
            foreach (var item in list)
            {
                if (item == element)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
