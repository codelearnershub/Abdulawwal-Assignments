using System;

namespace Question_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your conversion rate: 1$ = ----RMB");
            int ans = int.Parse(Console.ReadLine());

            Console.WriteLine("Press '0' to convert from $ to RMB (OR) '1' to convert from RMB to $");
            int ans1 = int.Parse(Console.ReadLine());

            int conversion = 0;

            if(ans1 == 0)
            {
                Console.WriteLine("Enter amount in $");
                int dollar = int.Parse(Console.ReadLine());
                conversion = ans * dollar;
                Console.WriteLine($" ${dollar}  = RMB{conversion}");
            }

            else if(ans1 == 1)
            {
                Console.WriteLine("Enter amount in RMB");
                int rmb = int.Parse(Console.ReadLine());
                conversion = rmb / ans ; 
                Console.WriteLine($" RMB{rmb}  = ${conversion}");
            }

            
        }
    }
}
