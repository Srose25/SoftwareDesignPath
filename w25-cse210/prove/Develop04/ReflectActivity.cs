public class ReflectActivity : Activity 
{
    //Attributes
    private List<string> promptList; 

    private List<string> questions;

    //Behaviors

    public ReflectActivity(string title, string desc)

    {
        this._title = title;
        this._desc = desc;

        promptList = new List<string>{
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
            "Think of a time when you were in need and someone helped you.",
            "Think of a time where you really felt at peace.",

        };

        questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "How did the experience change you?",
            "What made this experience stand out among the rest?",
            "What is your favorite thing about this experience?",
            "How can you keep this experience in mind in the future?",
            "What emotions did you feel during this experience?",
            "Who was with you, and how did they contribute to the moment?",
            "What details about this experience stand out the most?",
            "What did this moment teach you about yourself?",
            "If you could relive this experience, would you change anything?",
            "How did this experience make you feel connected to others?",
            "What strengths did you display during this moment?",
            "How does thinking about this memory make you feel right now?",
            "How can you create more experiences like this in the future?",
            "What words would you use to describe this moment to someone else?"
        };
    }

    public void DoReflect()
    {
        //Start message and get time from user
        StartMessage(_title, _desc);
        int time = Clock();
        Console.Clear();

        //Get random prompt from list and display it for the user, then prep them for the activity
        Random rand = new Random();
        string prompt = promptList[rand.Next(promptList.Count)];
        Console.WriteLine("Consider the Following Prompt: \n");
        Console.WriteLine($"---{prompt}---\n");
        Console.WriteLine("Press Enter to Continue:");
        Console.ReadLine();
        Console.WriteLine("Now, reflect on your memory while answering these questions.\n");
        Thread.Sleep(1000);

        //Variables for game loop
        int elapse = 0;
        List<int> chosen = new List<int>{};

        //The user will be asked a question about the memory they chose every 10 seconds
        while(elapse < time)
        {
            //In case the user is doing the activity longer than I have 
            //questions for, the program will crash so it doesn't infinitely loop
            if (chosen.Count >= questions.Count)
            {
                Console.Clear();
                Console.WriteLine("oopsies :)");
                Thread.Sleep(5000);
                break;
            }

            Random rand1 = new Random();
            int i = 0;

            //Another failsafe to make sure I don't ask the same question twice
            do
            {
                i = rand1.Next(questions.Count);
            } while(chosen.Contains(i));
            chosen.Add(i);

            //Display the question animate progress bar and update
            Console.WriteLine($"Question: {questions[i]}\n");
            AnimateProgressBar(10000 / 20);
            elapse += 10000;
        }

        //end message
        EndMessage(_title);
    }
}