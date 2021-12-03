
using System;

namespace Question_22
{
    class Program
    {
        static void Main(string[] args)
        
        {
            
             int max = 0;
             int i = 1;

            while( i > 0)
            {
                double power = Math.Pow(i , 3);

                if(power < 12000)
                {
                   max = i;
                }
                else
                {
                    break;
                }
                i++;
            }
            Console.WriteLine(max);
        }
    }
}
