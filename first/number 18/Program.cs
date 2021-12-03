using System;
using System.Collections.Generic;

namespace Question_18
{
    class Program
    {
        static void Main(string[] args)
        {
            
                int sum = 0;
                List<int> answers = new List<int>();
                Console.WriteLine("Choose an answer from the following global warming questions.");
                
                Console.WriteLine("1. Who measures the gl9obal warming rate ?  (a) Dentist     (b) Doctors   (c) Climatologist     (d) Socologist.");
                char ans1 = char.Parse(Console.ReadLine());

                Console.WriteLine("2. Which country produces the most greenhouse gases ?  (a) Zambia    (b) U.S.A   (c) Russia     (d) China.");
                char ans2 = char.Parse(Console.ReadLine());

                Console.WriteLine("3. When did global warming start ?  (a) 1830s     (b) 1930s   (c) 2002     (d) 2023.");
                char ans3 = char.Parse(Console.ReadLine());

                Console.WriteLine("4. Which of the following is the biggest cause of global warming ?  (a) CO2    (b) H2SO4  (c) CH3     (d) H2O.");
                char ans4 = char.Parse(Console.ReadLine());

                Console.WriteLine("5. Which of the following is not a greenhouse gas ?  (a) Methane    (b) Ozone  (c) Nitrogen     (d) Water vapour.");
                char ans5 = char.Parse(Console.ReadLine());

                if (ans1 == 'c')
                {
                    answers.Add(1);
                }

                if (ans2 == 'd')
                {
                    answers.Add(1);
                }

                if (ans3 == 'a')
                {
                    answers.Add(1);
                }

                if (ans4 == 'a')
                {
                    answers.Add(1);
                }

                if (ans5 == 'c')
                {
                    answers.Add(1);
                }
                
                foreach (var item in answers)
                {
                    sum+= item;
                    
                }
                
                    if (sum == 5)
                    {
                        Console.WriteLine(" Excellent!! you got all the questions right.");
                    }

                    else if (sum == 4)
                    {
                        Console.WriteLine(" Very good!! you got 4 questions right.");
                    }

                    else
                    {
                        Console.WriteLine(" Time to brush up on your knowledge of global warming!! you answered below 4 questions correctly.");
                        Console.WriteLine("Check facts on global warming questions on www.abdul.com ");
                    }
        }
    }
}
