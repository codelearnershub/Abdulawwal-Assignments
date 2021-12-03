
using System;

namespace Question_21
{
    class Program
    {
        static void Main(string[] args)
        {
            int  integer= 0;
            int i = 1;
          
            while ( i > 0 )
            {
               int power = i * i;
                if(power > 12000)
                {
                    integer = i;
                    Console.WriteLine(integer);
                    break; 
                }
                i++;
            }
            
        }
    }
}
