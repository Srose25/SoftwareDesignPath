using System.Globalization;

public class ChecklistGoal : Goal
{

    //Attributes
    private int _scount;
    private int _ecount;
    private int _bonus;


    //Behaviors

    public ChecklistGoal(string goal, string desc, int points, bool status, int scount, int ecount, int bonus)
    {
        _goal = goal;
        _gtype = "Checklist Goal";
        _desc = desc;
        _points = points;
        _scount = scount;
        _ecount = ecount;
        _bonus = bonus;
        _status = status;
    }

    public override string Display()//Returns a string for displaying in Menu
    {
        return $"{_gtype} - {_goal}: {_desc}. \nPoints: {_points} - Bonus: {_bonus} -- Completion: {_scount}/{_ecount}";
    }

    public override string ToString()//Returns a string with every data point
    {
        return $"{_gtype},{_goal},{_desc},{_points},{_status},{_bonus},{_scount},{_ecount}";
    }

    public override string RecordGoal()//Sets the name of the new goal
    {
        Console.WriteLine("What is your new Checklist Goal? ");
        _goal = Console.ReadLine();
        return _goal;
    }

    public override string SetDesc()//Sets the description of the new goal
    {
        Console.WriteLine($"Write a short description of ({_goal})");
        _desc = Console.ReadLine();
        return _desc;
    }

    public override int SetPoints()//Sets the amount of points for the new goal
    {
        while(true)
        {
           Console.WriteLine("How many points should this be worth?");
           string number = Console.ReadLine();
    
    
           if (int.TryParse(number, out _points))
           {
               return _points;
           }
           else
           {
               Console.WriteLine("Invalid input. Please enter a valid number.");
           }
        }
    }

    public int SetBonus()//Sets the bonus 
    {
        while(true)
        {
            Console.WriteLine($"How much of a bonus do you want for completing all {_ecount}?");
            string number = Console.ReadLine();
            if (int.TryParse(number, out _bonus))
            {
                return _bonus;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }            
        }
    }

    public int SetEndCount()//Sets how many times you want to do this goal
    {
        while(true)
        {
            Console.WriteLine("How many times would you like to do this goal until marking it complete?");
            string number = Console.ReadLine();
            if (int.TryParse(number, out _ecount))
            {
                return _ecount;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }            
        }
        
    }

    public override int GetPoints()//Gets the amount of points if they haven't accomplished the goal yet
    {
        if(_scount == _ecount)
        {
            _points += _bonus;
        }
        return _points;
    }

    public override void RecordEvent()//Applies the bonus if the user has accomplished their goal
    {
        _scount += 1;
        if(_scount == _ecount)
        {
            _status = true;
        }
    }

    public override bool GetStatus()//Gets the status of the goal
    {
        return _status;
    }
}