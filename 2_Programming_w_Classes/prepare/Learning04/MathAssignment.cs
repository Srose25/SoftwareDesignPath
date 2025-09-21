public class MathAssignment : Assignment
{

    //Attributes
    string _section;

    string _problems;


    //Behaviors

    public MathAssignment(string studentName, string topic, string section, string problems)
        : base(studentName, topic)
    {
        _section = section;
        _problems = problems;

    }


    public string GetHomeworkList()
    {
        string mathHomework = $"Section: {_section} - Problems: {_problems}";
        return mathHomework;
    }

}