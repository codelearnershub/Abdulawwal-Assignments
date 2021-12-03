
using System;

namespace Question_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your loan amount? ");
            double loanAmount = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your loan period in number of years");
            double loanPeriod =int.Parse(Console.ReadLine());

            double interest = 0;
            double loanPerMonth = 12/loanPeriod;
            double result = 0;
            
      
            

            
                
                for(double i = 5; i < 8 ; i+=0.125)
                {
                    double total = 0;
                    for(int k = 1; k <= loanPerMonth; k++)
                    {   
                    
                      
                        if(k == 1)
                        {    
                            interest = i/100;
                            result = loanAmount + interest;
                            Console.WriteLine($"The {k}st monthly pay at {i}%  =  {result}");
                        }   
                        if(k > 1)
                        {   
                            result = result + interest;
                            total+=result;

                            Console.WriteLine($"The {k} monthly pay at {i}%  =  {result}");
                        }
                        if(k == loanPerMonth)
                        {
                            Console.WriteLine($"The total monthly pay  =  {total}");
                        } 
                       
                    }
                    Console.WriteLine();
                    

                    
                    
                    
                    
                    
                }
              
        }
        

        
    }
}
