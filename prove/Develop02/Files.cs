using System.IO;
public class Files // For handling file reads and saves
{
// create a list to hold new entries until save
    public List<Entry> _addEntry = new List<Entry>(); // create a list that new entries can be added into
    public List<Entry> _loadedEntry = new List<Entry>(); // create a list that already saved entries can be added into
    public string _saveFileName;

    public void ShowEntries() // display entries that have been recorded
    {
        foreach (Entry i in _addEntry) // loop through the '_addEntry' list
        {
            i.Display(); // call the entry 'Display' method to print each journal entry as the loop iterates
        }
    }

    public void ShowLoadedEntries() // display entries that have been recorded
    {
        foreach (Entry i in _loadedEntry) // loop through the '_addEntry' list
        {
            i.Display(); // call the entry 'Display' method to print each journal entry as the loop iterates
        }
    }
    
    public void LoadFileNames()
    {
        string[] lines = System.IO.File.ReadAllLines("filenames.txt"); // read available filenames for loading into an array
        Console.WriteLine("Available Files:");
        foreach (string line in lines)
        {
            Console.WriteLine($"{line}"); // print the name of each file that can be loaded
        }
    }

    public void WriteEntries()
    {
        bool fileExists = false;
        string fileName = _saveFileName;
        
        string[] lines = System.IO.File.ReadAllLines("filenames.txt"); // read existing filenames then check for current filename existence
        foreach (string line in lines)
        {
            if (line == _saveFileName)
            {
                fileExists = true; // current filename exists - do nothing
                break;
            }
        }

        if (!fileExists)
        {
            using (StreamWriter outputFile = new StreamWriter("filenames.txt")) // current filename doesn't exist - add to filenames.txt
            {
                foreach (string line in lines) // StreamWriter will overwrite file contents so use previously loaded contents to populate the file
                {
                    outputFile.WriteLine($"{line}");
                }
                outputFile.WriteLine($"{_saveFileName}"); // then add the newest filename
            }
        }

        string[] savedEntries = System.IO.File.ReadAllLines(_saveFileName); // read existing filenames then check for current filename existence
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (string i in savedEntries) // loop through the 'savedEntries' list that is all the previously saved entries from the current file in use
            {
                outputFile.WriteLine($"{i}"); // print previous entries to the file since Streamwriter will overwrite the file contents
            }
            foreach (Entry i in _addEntry) // loop through the '_addEntry' list
            {
                outputFile.WriteLine($"{i._date}, {i._entryText}"); // print new entries to the file
            }
        }
        _addEntry.Clear();
    }
}