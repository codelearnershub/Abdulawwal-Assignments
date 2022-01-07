using System;

namespace num2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static void Asd(int[] nums)
        {
            
            for (int i = 0; i < nums.Length; i++)
            {
                int count = 0;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if(nums[i] == nums[j])
                    {
                        count++;
                    }
                }
            }
        }
    }
}
