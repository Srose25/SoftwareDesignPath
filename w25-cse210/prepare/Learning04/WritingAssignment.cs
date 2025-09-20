public class WritingAssignment : Assignment
{

    //Attributes

    string _title;


    //Behaviors

    public WritingAssignment(string studentName, string topic, string title)
        : base (studentName, topic)
    {
        _title = title;
    }


    public string GetWritingInfo()
    {
        string writingInfo = $"Writing Info: {_title}";
        return writingInfo;

    }

}