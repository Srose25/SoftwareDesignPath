public class CaveArea : Area 
{
    public CaveArea(int depression, bool shovel, bool fishpole, bool rock, bool locket, bool picture, bool musbox, bool Gkey, bool Rkey, bool Ckey)
        : base(depression, shovel, fishpole, rock, locket, picture, musbox, Gkey, Rkey, Ckey)
    {}
    public void CaveStart()
    {
        Console.Clear();
        PlaySound("the_cave.wav");
        PrintResponse("describe_cave");
        bool running = true;

        while(running)
        {

            Console.WriteLine("1. Bottomless Pit");
            Console.WriteLine("2. Dig a Rock");
            Console.WriteLine("3. Memorial");
            Console.WriteLine("4. Go Back");
            Console.WriteLine("5. Hint");

            string choice = Console.ReadLine();

            switch(choice)
            {
                case "1":                               //Music Box
                if(_rock && _fishpole == true)
                {
                    PlaySound("mus_box.wav");           //Check and make sure that's the name of the file
                    PrintResponse("pit_pole_rock");
                    Console.WriteLine("Do you want to break the music box? y/n");
                    string rchoice = Console.ReadLine();
                    if(rchoice == "y")
                    {
                        _musbox = true;
                        Console.WriteLine("The Music Box was destroyed.");
                        PlaySound("anger.wav");
                        _depression += 1;
                        SetMood();
                        CollectItem("Broken Music Box");
                    }
                    else if(rchoice == "n")
                    {
                        Console.WriteLine("You left the Music Box alone");
                        Thread.Sleep(2000);
                    }
                }
                else if(_rock && _locket == true)
                {
                    PrintResponse("repeat");
                    Console.WriteLine();
                }
                else
                {
                    PrintResponse("locket_norock");
                    Console.WriteLine();
                }
                break;

                case "2":                               //Rock
                if (_shovel == true)
                {
                    PrintResponse("rock_shovel");
                    _rock = true;
                    CollectItem("The Rock");
                    Console.WriteLine();
                }
                else if (_rock == true)
                {
                    PrintResponse("repeat");
                    Console.WriteLine();
                }
                else
                {
                    PrintResponse("rock_noshovel");
                    Console.WriteLine();
                }
                break;

                case "3":                               //Memorial
                if (_shovel == true)
                {
                    PrintResponse("memo_shovel");
                    Console.WriteLine();
                    _Ckey = true;
                    PlaySound("key_found.wav");
                    PrintResponse("key_found");
                    CollectItem("Cave Key");
                    Thread.Sleep(1000);
                }
                else if(_Ckey == true)
                {
                    PrintResponse("repeat");
                    Console.WriteLine();
                }
                else
                {
                    PrintResponse("memo_noshovel");
                    Console.WriteLine();
                }
                break;

                case "4":                               //Go Back
                running = false;
                break;

                case "5":                               //Hint
                PrintResponse("cave_hint");
                break;
            }
        }
    }
}