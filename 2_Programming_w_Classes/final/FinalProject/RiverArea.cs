using System.Xml.Serialization;

public class RiverArea : Area
{
    public RiverArea(int depression, bool shovel, bool fishpole, bool rock, bool locket, bool picture, bool musbox, bool Gkey, bool Rkey, bool Ckey)
        : base(depression, shovel, fishpole, rock, locket, picture, musbox, Gkey, Rkey, Ckey)
    {}
        public void RiverStart()
    {
        Console.Clear();
        PlaySound("the_river.wav");
        PrintResponse("describe_river");
        bool running = true;

        while(running)
        {
            Console.WriteLine("1. Go fishing");
            Console.WriteLine("2. The Little Boat");
            Console.WriteLine("3. Mound of Dirt");
            Console.WriteLine("4. Go Back");
            Console.WriteLine("5. Hint");

            string choice = Console.ReadLine();

            switch(choice)
            {
                case "1":                           //Go Fishing
                if (_fishpole == true)
                {
                    PrintResponse("fishing_pole");
                    Console.WriteLine();
                    _Rkey = true;
                    PlaySound("key_found.wav");
                    PrintResponse("key_found");
                    CollectItem("Seaweed Key");
                    Thread.Sleep(1000);
                }
                else if(_Rkey == true)
                {
                    PrintResponse("repeat");
                    Console.WriteLine();
                }
                else
                {
                    PrintResponse("fishing_nopole");
                    Console.WriteLine();
                }
                break;

                case "2":                          //The Little Boat
                if (_shovel == true)
                {
                    PrintResponse("boat_shovel");
                }
                else
                {
                    PrintResponse("boat_noshovel");
                    _shovel = true;
                    CollectItem("Shovel");
                }
                break;

                case "3":                       //Mound of Dirt
                if(_rock == true)
                {
                    PrintResponse("mound_rock");
                    Console.WriteLine("Do you want to break the Picture? y/n");
                    string rchoice = Console.ReadLine();
                    if(rchoice == "y")
                    {
                        _picture = true;
                        Console.WriteLine("The Picture was destroyed.");
                        PlaySound("anger.wav");
                        _depression += 1;
                        SetMood();
                        CollectItem("Broken Picture");
                    }
                    else if(rchoice == "n")
                    {
                        Console.WriteLine("You left the picture alone");
                        Thread.Sleep(2000);
                    }
                }
                else if (_picture == true)
                {
                    PrintResponse("repeat");
                    Console.WriteLine();
                }
                else
                {
                    PrintResponse("mound_norock");
                    Console.WriteLine();
                }
                break;

                case "4":                       //Go Back
                running = false;
                break;

                case "5":                       //Hint
                PrintResponse("river_hint");
                break;
            }
        }
    }
}