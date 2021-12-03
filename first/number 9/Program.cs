using System;

namespace Question_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter edge1");
            int edge1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter edge2");
            int edge2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter edge3");
            int edge3 = int.Parse(Console.ReadLine());

            int sum1 = edge1 + edge2;
            int sum2 = edge2 + edge3;
            int sum3 = edge1 + edge3;


            if(sum1 > edge3 && sum2 > edge1 && sum3 > edge2)
            {
                Console.WriteLine("Your input is valid");
            }

            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
