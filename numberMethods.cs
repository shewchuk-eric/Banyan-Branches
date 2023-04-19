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
        Random randomGenerator = new Random(); // create a random number generator
        int number = randomGenerator.Next(1, 100); // 1 and 100 are the range of numbers the generator can deliver
            do
            {
                Console.Write("What is your guess? ");
                response = Console.ReadLine();
                guess = int.Parse(response); // .Parse turns a string number into a real number - can be any of the number types (int, float, double, etc.)
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