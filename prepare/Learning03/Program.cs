using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Fractionator!\n");

        Fraction wholeNumber = new Fraction();
        Console.WriteLine($"First Constructor: {wholeNumber.GetFractionString()}");

        Fraction numeratorOnly = new Fraction(5);
        Console.WriteLine($"Second Constructor: {numeratorOnly.GetFractionString()}");

        Fraction bothNumbers = new Fraction(5, 3);
        Console.WriteLine($"Third Constructor: {bothNumbers.GetFractionString()}");

        wholeNumber.SetTop(3);
        Console.WriteLine($"Set Numerator To: {wholeNumber.GetTop()}");
        wholeNumber.SetBottom(4);
        Console.WriteLine($"Set Denominator To: {wholeNumber.GetBottom()}");

        Console.WriteLine($"Fraction As A String: {wholeNumber.GetFractionString()}");
        Console.WriteLine($"Fraction In Decimal Format: {wholeNumber.GetDecimalValue()}");
    }
}