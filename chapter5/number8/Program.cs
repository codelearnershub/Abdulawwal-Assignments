using System;

namespace number8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 for string , 2 for int , 3 for double");
            byte ans = byte.Parse(Console.ReadLine());

            switch (ans)
            {
                case 1:
                    Console.WriteLine("Enter a word:");
                    string word = Console.ReadLine();
                    string asd = word += '*';
                    Console.WriteLine(asd);
                    break;
                case 2:
                    Console.WriteLine("Enter a digit:");
                    int digit = int.Parse(Console.ReadLine());
                    digit++;
                    Console.WriteLine(digit);
                    break;
                case 3:
                    Console.WriteLine("Enter a floating digit:");
                    double num = double.Parse(Console.ReadLine());
                    num++;
                    Console.WriteLine(num);
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
    }
}
