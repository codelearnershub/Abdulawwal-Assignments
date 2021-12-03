using System;
using System.Collections.Generic;

namespace Question_30
{
    class Program
    {
        static void Main(string[] args)
        {
           int countPositive = 0;
           int countNegative = 0;
           int sum = 0;
            for(;;)
            {
                Console.WriteLine("Enter a number: press 0 for end of input");
                int num = int.Parse(Console.ReadLine());
                sum += num;
                

                if(Check(num) == 4)
                {
                    countPositive++;
                }
                else if(Check(num) == 1)
                {
                    countNegative++;
                }
                
                if(num == 0)
                {
                    break;
                }
            }

            int x = countNegative + countPositive;
            int average = sum/x ;

            Console.WriteLine($"The user entered positive values {countPositive}");
            Console.WriteLine($"The user entered Negative values {countNegative}");
            Console.WriteLine($"The average of the values the user entered =  {average}");
        }

        static int Check ( int numbers)
        {
            int i = 0;
            if( numbers > 0 )
            {
                i = 4;
            }
          else if(numbers < 0)
            {
                i = 1;
            }
            return i;
        }
    }
}
