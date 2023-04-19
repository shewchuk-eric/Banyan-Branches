using System;

class Program
{
    static void Main(string[] args)
    {
        bool addMore = true; // cause input loop to run
        List<int> numbers = new List<int>(); // create list to store input numbers
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while(addMore) // run loop to get user input numbers
        {
            string userInput  = Console.ReadLine();
            int number = int.Parse(userInput);
            if (number != 0)
            {
                numbers.Add(number);
            }
            else
            {
                addMore = false;
            }
        }
        double total = 0;
        double largest = 0;
        double smallest = 10000000;
        foreach (double value in numbers)
        {
            total += value;
            if (value > largest)
            {
                largest = value;
            }
            else if (value < smallest && value > 0)
            {
                smallest = value;
            }
        }
        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {total/numbers.Count}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest positive number is: {smallest}");

        numbers.Sort(); // arrange list in ascending order
        Console.WriteLine($"The sorted list ascending is: {string.Join(",", numbers)}");
        numbers.Reverse(); // reverse list to descending order
        Console.WriteLine($"The sorted list descending is: {string.Join(",", numbers)}\n");
    }
}