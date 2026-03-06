using System;

namespace TeamCalculator
{
    public class Addition
    {
        public void DoAddition()
        {
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int result = num1 + num2;

            Console.WriteLine("Result: " + result);
        }
    }
}