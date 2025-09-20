using System.Runtime.CompilerServices;

public class Menu()
{
    //Attributes

    int _score = 0;
    List<Goal> _goalList = new List<Goal>{};


    //Behaviors
    public void Start()
    {
        bool running = true;

        while(running)
        {
            Console.Clear();
            Milestone();                                //Display milestone message
            Console.WriteLine();
            Console.WriteLine("1. Create New Goal");    //Displaying the Menu
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            string choice = Console.ReadLine();



            switch(choice)
            {
            case "1":                                   //Create a goal
            int gchoice = SelectGoalType();
            Console.Clear();
            if (gchoice == 1)                           //Simple Goal
            {
                SimpleGoal sgoal1 = new SimpleGoal("goal", "desc", 0, false );
                AnimateProgressBar(1000 / 10);
                Console.WriteLine("Simple Goal: \n");

                sgoal1.RecordGoal();
                sgoal1.SetDesc();
                sgoal1.SetPoints();
                _goalList.Add(sgoal1);
                AnimateProgressBar(1000 / 10);
            }

            else if (gchoice == 2)                      //Eternal Goal
            {
                EternalGoal egoal1 = new EternalGoal("goal", "desc", 0, false);
                AnimateProgressBar(1000 / 10);
                Console.WriteLine("Eternal Goal: \n");
                
                egoal1.RecordGoal();
                egoal1.SetDesc();
                egoal1.SetPoints();
                _goalList.Add(egoal1);
                AnimateProgressBar(1000 / 10);
            }

            else if (gchoice == 3)                      //Checklist Goal
            {
                ChecklistGoal cgoal1 = new ChecklistGoal("goal", "desc", 0, false, 0, 0, 0);
                AnimateProgressBar(1000 / 10);
                Console.WriteLine("Checklist Goal: \n");

                cgoal1.RecordGoal();
                cgoal1.SetDesc();
                cgoal1.SetPoints();
                cgoal1.SetEndCount();
                cgoal1.SetBonus();
                _goalList.Add(cgoal1);
                AnimateProgressBar(1000 / 10);
            }

            else                                        //failsafe
            {
                Console.WriteLine("Error");
                AnimateProgressBar(1000 / 10);
            }
            break;

            case "2":                                   //Display Goals
            AnimateProgressBar(500 / 10);
            Console.Clear();
            for (int i = 0; i < _goalList.Count; i++)
            {
                if (_goalList[i].GetStatus() == true)
                {
                    Console.WriteLine($"{i + 1}. [X] {_goalList[i].Display()}");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine($"{i + 1}. [ ] {_goalList[i].Display()}");
                    Console.WriteLine();                 
                }

            }
            Console.WriteLine("Press enter to go back to menu");
            Console.ReadLine();
            break;

            case "3":                                   //Save
            AnimateProgressBar(1000 / 10);
            Save();
            break;

            case "4":                                   //Load
            AnimateProgressBar(1000 / 10);
            Load();
            break;

            case "5":                                   //Accomplishing goal
            AnimateProgressBar(1000 / 10);
            RecordGoalEvent();
            break;

            case "6":                                   //Quit
            Console.Clear();
            Console.WriteLine("Thank you come back again soon!");
            running = false;
            break;
            }
        }
    }

    public int SelectGoalType()//This menu asks the player which type of goal they want to create
    {
        bool running = true;

        while(running)
        {
            Console.Clear();
            Console.WriteLine("What kind of goal do you want to set? \n");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");

            string choice = Console.ReadLine();

            switch(choice)
            {
                case "1":
                return 1;

                case "2":
                return 2;

                case "3":
                return 3;

                default: 
                running = false;
                break;
            }
        }
        return 0;
    }

public void RecordGoalEvent()       //Records a goal as stated from option 5
{
    Console.Clear();
    Console.WriteLine("Select a goal to record:");
    Console.WriteLine();

    for (int i = 0; i < _goalList.Count; i++)   //Displays Goals
    {
        if (_goalList[i].GetStatus() == true)
        {
            Console.WriteLine($"{i + 1}. [X] {_goalList[i].Display()}");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine($"{i + 1}. [ ] {_goalList[i].Display()}");
            Console.WriteLine();       
        }
    }

    if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= _goalList.Count)//Gets input and then figures out
    {                                                                                               //if it can choose that option
        Goal selectedGoal = _goalList[choice - 1];
        if(selectedGoal.GetStatus() == false)
        {
        selectedGoal.RecordEvent();

        _score += selectedGoal.GetPoints();
        AnimateProgressBar(1000 / 10);
        }
        else
        {
            Console.WriteLine("This Goal has already been accomplished");
            AnimateProgressBar(1000 / 10);
        }
    }
    else
    {
        Console.WriteLine("Invalid selection.");
        AnimateProgressBar(1000 / 10);
    }
}


public void Save()      //Saves your goals to a file of the User's choice
{
    Console.Write("Enter filename to save to: ");
    string fileName = Console.ReadLine();

    // Convert _goalList to a list of strings using LINQ
    List<string> lines = _goalList.Select(goal => goal.ToString()).ToList();

    File.WriteAllLines(fileName, lines);

    Console.WriteLine("Saving...");
    AnimateProgressBar(2000 / 10);
}


    public void Load()  //Loads goals from a file of the User's choice
    {
        Console.Write("Enter a file name to load from: ");
        string fileName = Console.ReadLine();

        if (File.Exists(fileName))
        {
            string[] lines = File.ReadAllLines(fileName);
            _goalList.Clear();

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');

                string gtype = parts[0];
                string goal = parts[1];
                string desc = parts[2];
                int points = int.Parse(parts[3]);
                bool status = bool.Parse(parts[4]);

                if(gtype == "Simple Goal")
                {
                    _goalList.Add(new SimpleGoal(goal, desc, points, status));
                }
                else if(gtype == "Eternal Goal")
                {
                    _goalList.Add(new EternalGoal(goal, desc, points, status));
                }
                else if(gtype == "Checklist Goal")
                {
                    int scount = int.Parse(parts[4]);
                    int ecount = int.Parse(parts[5]);
                    int bonus = int.Parse(parts[6]);
                    _goalList.Add(new ChecklistGoal(goal, desc, points, status, scount, ecount, bonus));
                }
            }
            Console.WriteLine("Loading...");
            AnimateProgressBar(2000 / 10);
        }
        else
        {
            Console.WriteLine("File Not Found");
            AnimateProgressBar(1000 / 10);
        }
    }

        public void AnimateProgressBar(int step)
    {
        //quite a bit of logic that helps animate the progress bar
        int barLength = 10;
        //[i] works as a clock of sorts making sure that each interval is stepping forward
        for (int i = 0; i < barLength; i++)
        {
            Console.Write("[");

            //[z] works to print out the entire progress bar with the right amount of - / # so that you can see the end of the progress bar
            for (int z = 0; z < barLength; z++ )
            {
                if (z > i)
                {
                    Console.Write("-");
                }
                else
                {
                    Console.Write("#");
                }
            }
            Console.Write("]");
            Thread.Sleep(step);

            Console.Write("\r");
        }
    }

    public void Milestone() // A method that will print a new piece of text whenever the user reaches a milestone
    {
        if(_score >= 10 && _score <= 50)
        {
            Console.WriteLine($"Congrats!");
            Console.WriteLine();
            Console.WriteLine($"Score: {_score}");
            Console.WriteLine("Next Goal: 50");
        }
        else if(_score >= 50 && _score <= 100)
        {
            Console.WriteLine($"Wow, you've come far!");
            Console.WriteLine();
            Console.WriteLine($"Score: {_score}");
            Console.WriteLine("Next Goal: 100");
        }
        else if(_score >= 100 && _score <=200)
        {
            Console.WriteLine($"I wish I was as motivated as you.");
            Console.WriteLine();
            Console.WriteLine($"Score: {_score}");
            Console.WriteLine("Next Goal: 200");
        }
        else if(_score >= 200 && _score <= 500)
        {
            Console.WriteLine($"Ok Ok I get it you're doing stuff with your life \nyou don't have to shove it in my face...");
            Console.WriteLine();
            Console.WriteLine($"Score: {_score}");
            Console.WriteLine("Next Goal: 500");
        }
        else if(_score >= 500  && _score <= 1000)
        {
            Console.WriteLine($"Does it ever end with you? \nYou ever gonna stop?");
            Console.WriteLine();
            Console.WriteLine($"Score: {_score}");
            Console.WriteLine("Next Goal: 1000");
        }
        else if(_score >= 1000 && _score <= 2000)
        {
            Console.WriteLine($"Listen, I'm tired boss. \nDo you know how hard it is to keep \ntrack of all these points?...");
            Console.WriteLine();
            Console.WriteLine($"Score: {_score}");
            Console.WriteLine("Next Goal: 2000");
        }
        else if(_score >= 2000 && _score <= 3000)
        {
            Console.WriteLine($"WHAT DO YOU WANT FROM ME??? \nA TROPHY? A STUFFED ANIMAL?? \nA MUG THAT SAYS (MORNING PERSON) ON IT OR SOMETHING??? \nWHAT?????");
            Console.WriteLine();
            Console.WriteLine($"Score: {_score}");
            Console.WriteLine("Next Goal: 3000");
        }
        else if(_score >= 3000 && _score <= 5000)
        {
            Console.WriteLine($"...");
            Console.WriteLine();
            Console.WriteLine($"Score: {_score}");
            Console.WriteLine("Next Goal: 5000");
        }
        else if(_score >= 5000 && _score <= 10000)
        {
            Console.WriteLine("I'm not showing your score anymore. \nLike, you're going straight to heaven at this point, \njust let me go back to sleep");
            Console.WriteLine();

            Console.WriteLine("Next Goal: 10000");
        }
        else if(_score >= 10000)
        {
            Console.WriteLine("zzz...");
            Console.WriteLine();

            Console.WriteLine("Next Goal: Infinity...");
        }
        else
        {
            Console.WriteLine("Welcome to the Goal Setting App!");
            Console.WriteLine();
            Console.WriteLine($"Score: {_score}");
        }

    }
}