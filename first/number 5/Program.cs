using System;

namespace Question_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double distance = Length(6, 5, 2, 9);
            Console.WriteLine($"The distance between the two points is {distance}");
        }

        static double Length(double x1 , double x2 , double y1, double y2)
        {
            double x = Math.Pow((x1 + x2) , 2);
            double y = Math.Pow((y1 + y2) , 2);
            double length = Math.Sqrt((x + y));
            return length;
        }
    }
}
