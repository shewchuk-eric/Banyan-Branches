
using System;

class Program
{
    static void Main(string[] args)
    {
        string response = "yes"; // WHILE loop
        while (response == "yes")
        {
            Console.Write("Do you want to continue? ");
            response = Console.ReadLine();
        }

        string response; // DO WHILE loop
        do
        {
            Console.Write("Do you want to continue? ");
            response = Console.ReadLine();
        } while (response == "yes");

        for (int i = 0; i < 10; i++) // FOR loop - can increment other ways than '++' - (int i=2; i<=20; i=i+2)
        {
            Console.WriteLine(i);
        }

        foreach (string color in colors) // FOR EACH loop
        {
            Console.WriteLine(color);
        }
    }
}