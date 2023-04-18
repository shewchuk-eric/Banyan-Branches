using System;

class Program
{
    static void Main(string[] args)
    {
        string response = "";
        int guess = 0;
        bool play = true;
        string playAgain = "";

        while (play)
        {   
        int tries = 0;
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
            do
            {
                Console.Write("What is your guess? ");
                response = Console.ReadLine();
                guess = int.Parse(response);
                tries ++;
                if (guess < number)
                {
                    Console.WriteLine("Too Low");
                }
                else if (guess > number)
                {
                    Console.WriteLine("Too High");
                } 
            } while (guess != number);
            
            Console.WriteLine($"Congratulations!  You got it in {tries} tries.");
            Console.Write("Would you like to play again? (yes/no) ");
            playAgain = Console.ReadLine();
            if (playAgain == "no")
            {
                play = false;
            }
        }
    }
}