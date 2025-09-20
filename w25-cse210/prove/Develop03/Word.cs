public class Word
{
    //Attributes
    private string _word;
    private bool _revealed;


    //Initialize
    public Word(string word)
    {
        _word = word;
        _revealed = true;
    }

    //Behaviors
    public void Reveal()
    {
        _revealed = true;
    }

    public void Hide()
    {
        _revealed = false;
    }

    public bool IsRevealed(bool _revealed)
    {
        return _revealed;
    }

    public string GetWordText()
    {
        return _revealed ? _word : "___";
    }

}