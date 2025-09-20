public class Journal {

    //Attributes
    public List<string> _entryList = new List<string>();


    //Behaviors

    //This function Adds each compiled entry to a list
    public void AppendEntry()
    {
        Entry newEntry = new Entry();

        newEntry.DisplayPrompt();
        newEntry.GetInput();
        Console.WriteLine(newEntry.CompileEntry());

        string compiledEntry = newEntry.CompileEntry();
        _entryList.Add(compiledEntry);
    }

    //This function Displays the journal
    public void DisplayJournal()
    {
        if (_entryList.Count == 0)
        {
            Console.WriteLine("No entries found.");
        }

        else
        {
            Console.WriteLine("Your Journal Entries:\n");
            foreach (string entry in _entryList)
            {
                Console.WriteLine(entry);
            }
        }    
    }

    //This function saves our journal to a file
    public void SaveJournal(string fileName)
    {
        File.WriteAllLines(fileName, _entryList);
        Console.WriteLine("Journal Successfully Saved");
    }

    //This function loads our journal from the file
    public void LoadJournal(string fileName)
    {
        if (File.Exists(fileName))
        {
            _entryList = new List<string>(File.ReadAllLines(fileName));
            Console.WriteLine("Journal Successfully Loaded");
        }
        
        else
        {
            Console.WriteLine("No Saved Journal Found.");
        }
    }
}


