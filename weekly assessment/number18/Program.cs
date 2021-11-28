using System;

namespace number18
{
    class Program
    {
        static void Main(string[] args)
        {
            int headCount = 0;
            int tailCount = 0;
            for (int i = 1; i <= 1000000; i ++)
            {
                Random nums = new Random();
                int toll = nums.Next(0, 2);
                if(toll == 0)
                {
                    headCount++;
                }
                else if(toll == 1)
                {
                    tailCount++;
                }
            }
            Console.WriteLine($"Head was tossed {headCount} times and tails was tossed {tailCount} times");
        }
    }
}
