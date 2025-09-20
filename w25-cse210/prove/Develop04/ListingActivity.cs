public class ListingActivity : Activity 
{
    //Attributes

    List<string> questions;
    //Behaviors

    public ListingActivity(string title, string desc)

    {
        this._title = title;
        this._desc = desc;

        questions = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",
            "What are some acheivements of yours this week?",
            "What were some good things about your day?",
            "What are some things that you would like to accomplish this week?"
        };
    }

    public void DoListing()
    {
        //Begin with the Start Message and get the time from user
        StartMessage(_title, _desc);
        int time = Clock();
        Console.Clear();

        //Get random prompt from the list and prep the user for activity
        Random rand = new Random();
        string question = questions[rand.Next(questions.Count)];
        Console.WriteLine($"Question:--- {question} ---\n");
        Console.WriteLine("Press Enter when you're ready to begin");
        Console.ReadLine();

        //Variables for game loop
        List<string> responses = new List<string>();
        int elapse = 0;
        DateTime startTime = DateTime.Now;

        //The user will be able to list as many things as they can think of until time runs out
        while (elapse < time)
        {
            if (Console.KeyAvailable)
            {
                Console.Write("-> ");
                string response = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(response))
                    responses.Add(response);
            }
            elapse = (int)(DateTime.Now - startTime).TotalMilliseconds;
        }

        //Ending Message
        Console.WriteLine($"Congrats! You wrote down {responses.Count} responses!");
        EndMessage(_title);
    }
}