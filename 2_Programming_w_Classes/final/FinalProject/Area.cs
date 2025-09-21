using System.Media;
public class Area
{
    //Attributes
    protected static int _depression;
    protected static bool _shovel;
    protected static bool _fishpole;
    protected static bool _rock;
    public enum MoodState
    {
        Neutral = 0,
        Depressed = 1,
        Angry = 2
    }
    protected static MoodState _moodLevel = MoodState.Neutral; //Different integer = Different mood

    protected static bool _locket;
    protected static bool _picture;                             
    protected static bool _musbox;                              

    protected static bool _Gkey;
    protected static bool _Rkey;
    protected static bool _Ckey;

    protected static List<string> _inventory = new List<string>{};

    //Behaviors
    public Area(int depression, bool shovel, bool fishpole, bool rock, bool locket, bool picture, bool musbox, bool Gkey, bool Rkey, bool Ckey)
    {
        _depression = depression;
        _shovel = shovel;
        _fishpole = fishpole;
        _rock = rock;
        _locket = locket;
        _picture = picture;
        _musbox = musbox;
        _Gkey = Gkey;
        _Rkey = Rkey;
        _Ckey = Ckey;
    }

    public void Start()
    {
        Console.Clear();
        PlaySound("");
        PrintResponse("begin");
        Thread.Sleep(5000);
        AreaMenu();
    }

    public void AreaMenu()
    {
        bool running = true;
        while(running)
        {
            Console.Clear();
            Console.WriteLine("Menu:\n");
            Console.WriteLine("1. Look Around"); //Menu options
            Console.WriteLine("2. Inventory");
            Console.WriteLine("3. Unlock the Box");
            Console.WriteLine("4. Quit");
            string choice = Console.ReadLine();

            switch(choice)
            {
                case "1":   //Look Around
                Console.WriteLine("Where would you like to look around?\n");
                Console.WriteLine("1. River Area");
                Console.WriteLine("2. Grass Area");
                Console.WriteLine("3. Cave Area");
                string area_choice = Console.ReadLine();

                switch(area_choice)
                {
                    case "1":
                    RiverArea rarea1 = new RiverArea( _depression, _shovel, _fishpole, _rock, _locket, _picture, _musbox, _Gkey, _Rkey, _Ckey);
                    rarea1.RiverStart();
                    break;

                    case "2":
                    GrassArea garea1 = new GrassArea(_depression, _shovel, _fishpole, _rock, _locket, _picture, _musbox, _Gkey, _Rkey, _Ckey);
                    garea1.GrassStart();
                    break;

                    case "3":
                    CaveArea carea1 = new CaveArea(_depression, _shovel, _fishpole, _rock, _locket, _picture, _musbox, _Gkey, _Rkey, _Ckey);
                    carea1.CaveStart();
                    break;

                    default:
                    Console.WriteLine("Invalid Option.");
                    break;
                }
                break;

                case "2":   //Inventory
                Console.Clear();
                Console.WriteLine("Inventory:");
                if (_inventory.Count == 0)
                {
                    Console.WriteLine("Your inventory is empty.");
                }
                else
                {
                    for (int i = 0; i < _inventory.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {_inventory[i]}");
                    }
                }
                Console.ReadLine();
                break;

                case "3":   //Unlock the Box / end the game
                if (_Gkey && _Rkey && _Ckey)
                {
                    End();
                    running = false;
                }
                else
                {
                    Console.WriteLine("Not yet...");
                    Thread.Sleep(3000);
                }
                break;

                case "4":   //End the game early
                running = false;
                break;
            }
        }
    }

    public void End()
    {
        Console.Clear();
        PlaySound("");
        PrintResponse("ending");
        Thread.Sleep(5000);
        Console.WriteLine("Thank you for playing my game!");
        Thread.Sleep(5000);
    }


    //Utility Methods
    public void SetMood()
    {
        if(_depression == 0 || _depression == 1)
        {
            _moodLevel = MoodState.Neutral;
        }
        else if(_depression == 2)
        {
            _moodLevel = MoodState.Depressed;
        }
        else if(_depression == 3)
        {
            _moodLevel = MoodState.Angry;
        }
    }

    public void CollectItem(string item)
    {
        _inventory.Add(item);
        Console.WriteLine("Item Collected!");
        Thread.Sleep(2000);
    }

    public void PrintResponse(string key)
    {
        if(_moodLevel == MoodState.Neutral)
        {
            Narrator neutralnarrator = new NeutralNarrator();
            string rndresponse = neutralnarrator.GetDialogue(key);
            neutralnarrator.DialogueSpeed(rndresponse);
        }
        else if(_moodLevel == MoodState.Depressed)
        {
            Narrator depressednarrator = new DepressedNarrator();
            string rndresponse = depressednarrator.GetDialogue(key);
            depressednarrator.DialogueSpeed(rndresponse);
        }
        else if(_moodLevel == MoodState.Angry)
        {
            Narrator angrynarrator = new AngryNarrator();
            string rndresponse = angrynarrator.GetDialogue(key);
            angrynarrator.DialogueSpeed(rndresponse);
        }
    }
    public void PlaySound(string key)
    {
        try
        {
            SoundPlayer player = new SoundPlayer(key);
            player.Play();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Failed to play sound: {ex.Message}");
        }
    }
}