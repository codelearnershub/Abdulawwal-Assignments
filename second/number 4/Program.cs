using System;

namespace Question_24
{
    class Program
    {
        static void Main(string[] args)
        {
            int count1 = 1;
            int count2 = 0;
            Console.WriteLine("The leap years between 2001 and 2100 are below:");
            for(int i = 2001; i < 2100; i++)
            {
                count1++;

                

                if(count1 == 5)
                {
                    
                    Console.Write(i);
                    Console.Write("    ");
                    count2++;
                    
                    if(count2 == 10)
                    {
                        Console.WriteLine();
                        count2 = 0;
                    }
                    count1 = 1;
                }
            }
        }
    }
}
