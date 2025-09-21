public class Verse
{

    //Attributes
    private List<Word> _wordList;
    private Reference _reference;

    //Initialize

    public Verse(string sentence, Reference reference)
    {
        _wordList = new List<Word>();
        _reference = reference;
        string[] words = sentence.Split(' '); // Split sentence into words

        foreach (string word in words)
        {
            _wordList.Add(new Word(word)); // Add each word to the list
        }
    }


    //Behaviors

    public void HideWords(int difficulty)
    {
        int count;

        //Create a switch case that converts the users input into a difficulty setting
        Random rng = new Random();
        switch (difficulty)
        {
            case 1:
            count = 1;
            break;
            
            case 2:
            count = 3;
            break;

            case 3:
            count = 5;
            break;

            default:
            count = 1;
            break;
        }

        //Create a method that picks the amount of words in the sentence to hide
        for (int i = 0; i< count; i ++)
        {
            int randomIndex = rng.Next(_wordList.Count);
            _wordList[randomIndex].Hide();
        }

    }

    //Method that gets the verse text through using Word
    public string GetVerseText()
    {
        string text = "";

        foreach (Word word in _wordList)
        {
            text += word.GetWordText() + " ";
        }

        return text;
    }

    public string GetReference()
    {
        return _reference.DisplayReference();
    }
}