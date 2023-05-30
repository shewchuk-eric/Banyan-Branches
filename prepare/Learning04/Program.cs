using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment testRun = new Assignment("George Washington", "Tree Felling");
        Console.WriteLine(testRun.GetSummary());
    }
}