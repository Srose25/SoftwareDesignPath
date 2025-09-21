public class Menu
{

    //Attributes
    //private int _difficulty; I don't think I need this tbh

    private List<Verse> _scripture;

    //Initialize
    public Menu()
    {
        _scripture = new List<Verse>()
        {
            new Verse("Adam fell that men might be; and men are that they might have joy", new Reference("2 Nephi", 2, 25)),
            new Verse("And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.", new Reference("1 Nephi", 3, 7)),
            new Verse("For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.", new Reference("John", 3, 16)),
            new Verse("The Spirit itself beareth witness with our spirit, that we are the children of God: And if children, then heirs; heirs of God, and joint-heirs with Christ; if so be that we suffer with him, that we may be also glorified together.", new Reference("Romans", 8, 16, 17)),
            new Verse("To him that overcometh will I grant to sit with me in my throne, even as I also overcame, and am set down with my Father in his throne.", new Reference("Revelation", 3, 21))
        };
    }

    //Behaviors

    //This Method prompts the user for which scripture they want to memorize
    public void SelectScripture()
    {
        while(true)
        {
            //Display available scripture options
            Console.WriteLine("Please Select a Verse\n");
            for(int i = 0; i < _scripture.Count; i ++)
            {
                Console.WriteLine($"{i + 1}. {_scripture[i].GetReference()}");
            }

            //get user input for the verse
            Console.WriteLine();
            string verseInput = Console.ReadLine()?.Trim().ToLower();


            //Different options [Logic]
            if (verseInput == "quit") return;

            if (int.TryParse(verseInput, out int index) && index >= 1 && index <= _scripture.Count)
            {
                Verse selectedScripture = _scripture[index - 1];
                SelectDifficulty(selectedScripture);
            }

            else
            {
                Console.WriteLine("Invalid Choice. Pick again.");
            }
        }
    }


    //This Method prompts the user for the difficulty
    public void SelectDifficulty(Verse verse)
    {

        while(true)
        {
            //Display Options
            Console.WriteLine("Please Select a Difficulty");
            Console.WriteLine("1. Easy");
            Console.WriteLine("2. Medium");
            Console.WriteLine("3. Hard");
            Console.WriteLine("quit");
            Console.WriteLine();

            //Get user input
            string choice = Console.ReadLine()?.Trim().ToLower();

            //Different Options [Logic]
            if (choice == "quit") return;

            if (int.TryParse(choice, out int difficulty) && difficulty >= 1 && difficulty <= 3)
            {
                Start(verse, difficulty);
            }

            else
            {
                Console.WriteLine("Invalid Option: Pick 1, 2, 3, or quit.");
            }
        }
    }


    public void Start(Verse verse, int difficulty)
    {
        while(true)
        {
            Console.Clear();
            Console.WriteLine("Press Enter to remove words from the verse. Type Quit to end\n");
            Console.WriteLine(verse.GetReference(),"\n");
            Console.WriteLine(verse.GetVerseText());

            string choice = Console.ReadLine()?.ToLower();

            if (choice == "quit") return;

            verse.HideWords(difficulty);
        }
    }
}