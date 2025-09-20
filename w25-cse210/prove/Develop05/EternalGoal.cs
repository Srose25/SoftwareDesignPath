public class EternalGoal : Goal
{

    //Attributes

    //Behaviors

    public EternalGoal(string goal, string desc, int points, bool status)
    {
        _goal = goal;
        _gtype = "Eternal Goal";
        _desc = desc;
        _points = points;
        _status = status;
    }

    public override string Display()//Returns a string for displaying in Menu
    {
        return $"{_gtype} - {_goal}: {_desc}. \nPoints: {_points}";
    }

    public override string ToString()//Returns a string with every data point
    {
        return $"{_gtype},{_goal},{_desc},{_points},{_status}";
    }

    public override string RecordGoal()//Sets the name of the new goal
    {
        Console.WriteLine("What is your new Eternal Goal? ");
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

    public override int GetPoints()//Gets the amount of points if they haven't accomplished the goal yet
    {
        return _points;
    }

    public override void RecordEvent(){}//This doesn't do anything because eternal goals won't ever be accomplished

    public override bool GetStatus()//This gets the status of the goal
    {
        return _status;
    }
}