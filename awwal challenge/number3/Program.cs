using System;

namespace number_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] heights = { 1, 6, 3, 5, 2 };
            Console.WriteLine($"number of huddles are {heights.Length} and");
            Console.WriteLine(HurdleRace(4, heights));
        }

        public static int HurdleRace(int k, int[] hurdles)
        {
            int height = k;
            int potion = 0;
            for (int i = 0; i < hurdles.Length; i++)
            {
                if (hurdles[i] > height)
                {
                    potion += hurdles[i] - height;
                    height = height + potion;
                }
            }
            return potion;
        }
    }
}
