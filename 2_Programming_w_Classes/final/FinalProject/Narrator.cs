public abstract class Narrator()
{
    protected readonly Dictionary<string, List<string>> _dialogue = new Dictionary<string, List<string>>();

    // Virtual methods
    public virtual string GetDialogue(string key)
    {
        return GetRandomResponse(_dialogue, key);
    }


    // Utility Method
    public string GetRandomResponse(Dictionary<string, List<string>> dictionary, string key)
    {
        if (dictionary.ContainsKey(key) && dictionary[key].Count > 0)
        {
            Random rnd = new Random();
            return dictionary[key][rnd.Next(dictionary[key].Count)];
        }
        return "The Narrator remains silent.";
    }

    //Abstract Method
    public abstract void DialogueSpeed(string sentence);
}