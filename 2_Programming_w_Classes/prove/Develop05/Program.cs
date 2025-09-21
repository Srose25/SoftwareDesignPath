using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");

        Menu programbegin = new Menu();
        programbegin.Start();
    }
}

//For the stretch activities I wanted to do a couple of things
//I really liked the progress bar I made for the last project
//So I was able to easily insert that into this project too.
//
//But my attempt for the stretch activity takes the concept
//of "gamifying" a goal setting app. I played games growing up
//that were fairly silly by nature and I wanted to add an element
//of that to this. The idea is to make an encouraging list of 
//messages that will motivate the player. I quickly had the idea
//"What's more motivating? Encouraging the user? Or jealousy?"
//I then made the Narrator be a little bit more snarky in his
//comments the more you progress in the game, creating a round
//about way of motivating the user into proving this game wrong
//by showing that they can keep accomplishing goals. Let me know 
//if you think this was a good addition or not!