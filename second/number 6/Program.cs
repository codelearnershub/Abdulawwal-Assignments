using System;
using System.Collections.Generic;

namespace Question_26
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            List<int> numbers= new List<int>();
            for(int i = 5; i <  10000; i++)
            {
                
                for(int k = 1; k < i ; k++)
                {
                    
                    if(i % k == 0)
                    {
                        sum = sum + k;
                        
                    }
                    
                }

                if(sum == i)
                {
                    numbers.Add(i);
                    sum = 0;
                }
                else
                {
                    sum = 0;
                }
                
            }

            Console.WriteLine($"The four perfect number between 1 and 10000 are : {String.Join(',' , numbers)}");
        }
    }
}
