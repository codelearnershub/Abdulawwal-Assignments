using System;

namespace Question_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter third number: ");
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter fourth number: ");
            int num4 = int.Parse(Console.ReadLine());

            int additionNum1 = num1 + 7;
            int additionNum2 = num2 + 7;
            int additionNum3 = num3 + 7;
            int additionNum4 = num4 + 7;

            int divisionNum1 = additionNum1 / 10;
            int divisionNum2 = additionNum2 / 10;
            int divisionNum3 = additionNum3 / 10;
            int divisionNum4 = additionNum4 / 10;

            int modulosNum1 = additionNum1 % 10;
            int modulosNum2 = additionNum2 % 10;
            int modulosNum3 = additionNum3 % 10;
            int modulosNum4 = additionNum4 % 10;

            modulosNum1 = modulosNum1 + modulosNum3;
            modulosNum3 = modulosNum1 - modulosNum3;
            modulosNum1 = modulosNum1 - modulosNum3;

            Console.WriteLine($"The encrypted numbers are {modulosNum1},  {modulosNum2},  {modulosNum3},  {modulosNum4}");

            modulosNum1 = modulosNum3 + modulosNum1;
            modulosNum3 = modulosNum1 - modulosNum3;
            modulosNum1 = modulosNum1 - modulosNum3;

            int multiplication1 = divisionNum1 * 10;
            int multiplication2 = divisionNum2 * 10;
            int multiplication3 = divisionNum3 * 10;
            int multiplication4 = divisionNum4 * 10;

            int return1 = modulosNum1 + multiplication1;
            int return2 = modulosNum2 + multiplication1;
            int return3 = modulosNum3 + multiplication1;
            int return4 = modulosNum4 + multiplication1;

            int finalReturn1 = return1 - 7;
            int finalReturn2 = return2 - 7;
            int finalReturn3 = return3 - 7;
            int finalReturn4 = return4 - 7;

            Console.WriteLine($"The return encrypted are {finalReturn1}, {finalReturn2}, {finalReturn3}, {finalReturn4} ");
        
        }

    }
}
