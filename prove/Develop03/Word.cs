public class Word
{
    private List<int> _used = new List<int>(); // holds the word index positions that have been blanked out
    private string[] _progress = new string[] {}; // use for blanking out individual words as the app progresses
    private int _wordCount; // use with WordBlanker to know how many words are in the scripture verse
    private bool _status = true;
    private string _citation; // holds the verse citation
    private string _verse; // holds the verse as it works through the progressive blanking of individual words
   
    public Word(string citation, string verse)
    {
        _verse = verse;
        BuildArray(verse);
        _citation = citation;
    }

    private void BuildArray(string verse)
    {
        _progress = verse.Split(" "); // split the verse into component parts
        _wordCount = _progress.Length;
    }
    
    public void WordBlanker() // select random numbers to choose which 3 words to blank out on each cycle through
    {
        Random randomGenerator = new Random(); // create a random number generator
        bool loopAgain = true; // keeps loop running until 3 words have been blanked or until the last word is blanked
        int iterator = 0; // count successful random number selections
        while (loopAgain) // loop until 3 words have been blanked out
        {
        int number = randomGenerator.Next(0, _wordCount);
        if (_used.Contains(number)) // check if random number has been used already
            {
                continue; // random number already used so get another one           
            }
        else // take word from array, blank it out and then put the blanks back in its place
            {
                iterator ++; // random number not used yet
                _used.Add(number); // add number to used numbers list so it cannot be used again
                string blankWord = _progress[number]; // get the word at random position
                foreach (char i in blankWord) // loop through the characters to replace them
                    {
                        blankWord = blankWord.Replace(i, '_'); // replace each character with a underscore
                    }
                _progress[number] = blankWord; // put the blanked word into the array
                if (_wordCount == _used.Count) // all words have been blanked so kill run
                {
                    loopAgain = false;
                    _status = false;
                    break;
                }
            }
        if (iterator == 3) // need to loop 3 times to blank out three words each cycle
            {
                loopAgain = false; // break the loop
            }
        }
    }

    public string ScriptureGetter()
    {
        _verse = string.Join(' ', _progress);
        string scripture = ($"{_citation} - {_verse}");
        return scripture;
    }

    public bool DoneYet()
    {
        return _status;
    }
}