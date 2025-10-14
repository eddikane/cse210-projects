using System;

class Program
{
    static void Main(string[] args)
    {
        // Fraction 1 -> using default constructor (1/1)
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());   // 1/1
        Console.WriteLine(f1.GetDecimalValue());     // 1

        // Fraction 2 -> using one-parameter constructor (5/1)
        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());   // 5/1
        Console.WriteLine(f2.GetDecimalValue());     // 5

        // Fraction 3 -> using two-parameter constructor (3/4)
        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString());   // 3/4
        Console.WriteLine(f3.GetDecimalValue());     // 0.75

        // Fraction 4 -> using two-parameter constructor (1/3)
        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFractionString());   // 1/3
        Console.WriteLine(f4.GetDecimalValue());     // 0.33333333333333
    }
}
