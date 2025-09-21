using System;

class Program
{
    static void Main(string[] args)
    {
        Activity activity1 = new Activity();
        activity1.Welcome();

        //For this activity I had two stretch goals in mind for this activity
        //
        //The first was to animate a progress bar because for some reason the spinner
        //really stressed me out which I didn't want my users to feel using the program
        //
        //The second was to make sure that in the Reflect activity we ran into as little bugs
        //as possible. I wanted to make sure that we didn't have any repeat questions but that 
        //ran me into a problem. If I made sure there were no repeat questions with loop I created
        //eventually I would create an infinite loop which is not good. So, I designed a fail safe
        // that will say "oopsies :)" just to be safe. Let me know if you are able to get it to say that!
    }
}