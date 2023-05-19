using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture quotable = new Scripture(); // create scripture and select the verse for this round
        Display writeVerse = new Display(); // create access to the Display methods
        Word blankWords = new Word(quotable.GetCitation(), quotable.GetVerse());
        writeVerse.OutputOne(quotable.GetCitation(), quotable.GetVerse()); // print scripture first time

        bool _runApp = true;

        while(_runApp)
        {
            Console.Write("Press ENTER to continue or type 'quit' to end. ");
            string input = Console.ReadLine();
            if (input == "")
                {
                   blankWords.WordBlanker(); // enter key is pressed - blank out three words
                   string scripture = blankWords.ScriptureGetter(); // get the new string with blanked out words
                   writeVerse.OutputTwo(scripture); // print the new string
                   _runApp = blankWords.DoneYet(); // if all words are blanked this sets the loop to false
                   if (!_runApp)
                   {
                    Console.WriteLine($"Thanks for using the Memorizer");
                   }
                }
            else if (input =="quit")
                {
                    _runApp = false;
                }
            else
                {
                    Console.WriteLine("Invalid selection. Please try again.");
                    continue;
                }
        }
    }
}