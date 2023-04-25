using System;

// Author: Eric Shewchuk

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        float number = PromptUserNumber();
        float square = SquareNumber(number);
        DisplayResult(name, number, square);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        return name;
    }

    static float PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string num = Console.ReadLine();
        float number = float.Parse(num);
        return number;
    }

    static float SquareNumber(float number)
    {
        float square = number * number;
        return square;
    }

    static void DisplayResult(string name, float number, float square)
    {
        Console.WriteLine($"Hi {name}, the square of {number} is {square}");
    }
}