using System;

class Program
{
    static void Main()
    {
        // Test out the Fraction class
        Fraction f1 = new Fraction();          // 1/1
        Fraction f2 = new Fraction(5);         // 5/1
        Fraction f3 = new Fraction(3, 4);      // 3/4

        Console.WriteLine(f1.GetFractionString());  // "1/1"
        Console.WriteLine(f1.GetDecimalValue());    // 1.0

        Console.WriteLine(f2.GetFractionString());  // "5/1"
        Console.WriteLine(f2.GetDecimalValue());    // 5.0

        Console.WriteLine(f3.GetFractionString());  // "3/4"
        Console.WriteLine(f3.GetDecimalValue());    // 0.75
    }
}
