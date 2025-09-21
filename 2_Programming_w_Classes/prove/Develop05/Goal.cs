public abstract class Goal
{

    //Attributes

    protected string _goal;
    protected string _gtype;
    protected string _desc;
    protected int _points;
    protected bool _status;


    //Behaviors
    public Goal(){}                 //An Abstract class that list the attributes and functionality of a goal
                                    //That's meant to be overriden by child classes for different versions 
                                    //of Goals

    public abstract string Display();
    public abstract string RecordGoal();
    public abstract string SetDesc();
    public abstract int SetPoints();
    public abstract int GetPoints();
    public abstract bool GetStatus();
    public abstract void RecordEvent();
}