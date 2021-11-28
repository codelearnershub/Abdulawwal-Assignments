using System;

namespace number19
{
    class Program
    {
        static void Main(string[] args)
        {
            for (double i = 1; i <= 40; i +=1)
            {
                double pow = Math.Pow(2, i);
                Console.WriteLine(pow);
            }
        }
    }
}
