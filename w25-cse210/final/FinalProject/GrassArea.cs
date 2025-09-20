public class GrassArea : Area
{
    public GrassArea(int depression, bool shovel, bool fishpole, bool rock, bool locket, bool picture, bool musbox, bool Gkey, bool Rkey, bool Ckey)
        : base(depression, shovel, fishpole, rock, locket, picture, musbox, Gkey, Rkey, Ckey)
    {}
        public void GrassStart()
    {
        Console.Clear();
        PlaySound("the_grass.wav");
        PrintResponse("describe_grass");
        bool running = true;

        while(running)
        {
            Console.WriteLine("1. The Tree House");
            Console.WriteLine("2. The Locket");
            Console.WriteLine("3. The Hill");
            Console.WriteLine("4. Go Back");
            Console.WriteLine("5. Hint");

            string choice = Console.ReadLine();

            switch(choice)
            {
                case "1":               //Treehouse
                if (_rock == true)
                {
                    PrintResponse("treehouse_rock");
                    Console.WriteLine();
                    _Gkey = true;
                    PlaySound("key_found.wav");
                    PrintResponse("key_found");
                    CollectItem("Treehouse Key");
                    Thread.Sleep(1000);
                }
                else if(_Gkey == true)
                {
                    PrintResponse("repeat");
                    Console.WriteLine();
                }
                else
                {
                    PrintResponse("treehouse_norock");
                    Console.WriteLine();
                }
                break;

                case "2":               //Locket
                if(_rock == true)
                {
                    PrintResponse("locket_rock");
                    Console.WriteLine("Do you want to break the locket? y/n");
                    string rchoice = Console.ReadLine();
                    if(rchoice == "y")
                    {
                        _locket = true;
                        Console.WriteLine("The Locket was destroyed.");
                        PlaySound("anger.wav");
                        _depression += 1;
                        SetMood();
                        CollectItem("Broken Locket");
                    }
                    else if(rchoice == "n")
                    {
                        Console.WriteLine("You left the locket alone");
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

                case "3":               //The Hill
                if (_shovel == true)
                {
                    PrintResponse("hill_shovel");
                    _fishpole = true;
                    CollectItem("Fishing Pole");
                    Console.WriteLine();
                }
                else if (_fishpole == true)
                {
                    PrintResponse("repeat");
                    Console.WriteLine();
                }
                else
                {
                    PrintResponse("hill_noshovel");
                    Console.WriteLine();
                }
                break;

                case "4":               //Go Back
                running = false;
                break;

                case "5":               //Hint
                PrintResponse("grass_hint");
                break;
            }
        }
    }
}