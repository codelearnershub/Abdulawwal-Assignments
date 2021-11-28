using System;

namespace number6
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = { 8, 5, 3, 6, 2, 4 };
            double minValue = Min(array);
            Console.WriteLine(minValue);
        }

        public static double Min(double[] array)
        {
            double minimum = array[0];
            foreach (var i in array)
            {
                if (i < minimum)
                {
                    minimum = i;
                }
            }
            return minimum;
        }
    }
}
