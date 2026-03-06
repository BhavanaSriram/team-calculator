using System;

class Program
{
    static void Main(string[] args)
    {
        Addition add = new Addition();
        Subtraction sub = new Subtraction();
        Multiplication mul = new Multiplication();

        Console.WriteLine("Addition: " + add.DoAddition(10, 5));
        Console.WriteLine("Subtraction: " + sub.DoSubtraction(10, 5));
        Console.WriteLine("Multiplication: " + mul.DoMultiplication(10, 5));
    }
}