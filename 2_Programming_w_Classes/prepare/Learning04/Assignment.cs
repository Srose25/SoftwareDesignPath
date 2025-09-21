public class Assignment 
{

//Attributes

string _studentName;

string _topic;


//Behaviors

    public Assignment(string studentName, string topic)
    {

        _studentName = studentName;

        _topic = topic;
    }


    public string GetSummary()
    {

        string summary = $"{_studentName} - {_topic}";
        return summary;
    }
}
