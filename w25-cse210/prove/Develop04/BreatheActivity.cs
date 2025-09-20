public class BreatheActivity : Activity 
{

    public BreatheActivity(string title, string desc)

    {
        this._title = title;
        this._desc = desc;
    }

    public void DoBreathe()
    {
        //Start message and get time from user
        StartMessage(_title, _desc);
        int time = Clock();
        Console.Clear();

        //A little thing to be nice to the user
        Console.WriteLine("Press Enter to Begin:");
        Console.ReadLine();
        Console.Clear();

        //variable for game loop
        int elapse = 0;

        //The user will be prompted to breathe in / out along with a progress bar
        while (elapse < time)
        {
            Console.WriteLine($"Breathe in...");
            AnimateProgressBar(5000 / 20);

            Console.WriteLine();
            
            Console.WriteLine($"Breathe Out...");
            AnimateProgressBar(5000 / 20);

            Console.WriteLine();
            elapse += 10000;
        }

        //ending message
        EndMessage(_title);
    }
}