using System;

namespace Question_27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of seconds");
            int seconds = int.Parse(Console.ReadLine());
        
            for(int i = 1; i <= seconds; i++)
            {
               Console.WriteLine("Your time has been deducted by a second");
            
            }
        }
    }
}
