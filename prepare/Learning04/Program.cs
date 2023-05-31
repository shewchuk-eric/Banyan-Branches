using System;

class Program
{
    static void Main(string[] args)
    {
        // use variables to send to constructors since actual programs will work that way
        string name = "Alan Turing";
        string topic1 = "Math For Cyphers";
        string topic2 = "Encryption In World War II";
        string section = "8.23";
        string problems = "7-17";
        string title = "How To Encrypt A Secret by Don Chu No";

        // base assignment class
        Assignment codedMessage = new Assignment(name, topic1);
        Console.WriteLine(codedMessage.GetSummary() + $"\n");

        // math assignment class
        MathAssignment secretMessage = new MathAssignment(name, topic1, section, problems);
        Console.WriteLine(secretMessage.GetSummary());
        Console.WriteLine(secretMessage.GetHomeworkList() + $"\n");

        // writing assignment class
        WritingAssignment story = new WritingAssignment(name, topic2, title);
        Console.WriteLine(story.GetSummary());
        Console.WriteLine(story.GetWritingInformation() + $"\n");
    }
}