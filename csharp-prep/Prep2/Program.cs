using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade score? ");
        string score = Console.ReadLine(); // get user input
        double grade = double.Parse(score); // convert input string into a number
        string letterGrade = "";

        if (grade >= 90) // test grade score values to find letter grade
        {
            letterGrade = "A";
        }
        else if (grade >= 80 && grade < 90)
        {
            letterGrade = "B";
        }
        else if (grade >= 70 && grade < 80)
        {
            letterGrade = "C";
        }
        else if (grade >= 60 && grade < 70)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        string sign = ""; // default grade sign is blank
        double gradeSign = grade%10; // find second full number digit to test for grade sign value

        if (gradeSign >= 7 && letterGrade != "A" && letterGrade != "F") // test for need to add '+' or '-' to letter grade
        {
            sign = "+";
        }
        else if (gradeSign < 3 && letterGrade != "F")
        {
            sign = "-";
        }

        string pass = "You failed. Perhaps spend more time studying.";
        if (letterGrade != "F" && letterGrade != "D")
        {
            pass = "Congratulations, you passed!";
        }

        Console.WriteLine($"{pass}");
        Console.WriteLine($"Your grade is {letterGrade}{sign}");
    }
}