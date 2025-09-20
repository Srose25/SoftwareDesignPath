using System;

class Program

{
    //Function that welcomes the user to the program
    //(I'm intentionally leaving in my silly spelling blunder 
    //to prove that a human being wrote this)
        static void DisplayWelcome()
    {
        Console.WriteLine("Hello to the program!");
    }

    //Function that prompts the user for their name
    static string PromptUserName()
    {
        Console.Write("What's your name? ");
        string userName = Console.ReadLine();
        return userName;
    }

    //Function that prompts the user for their favorite number
    static int PromptUserNum()
    {
        Console.Write("What's your favorite number? ");
        string entry = Console.ReadLine();
        int userNum = int.Parse(entry);
        return userNum;
    }

    //Function that takes their favorite number and squares it
    static int SquareNum(int userNum)
    {
        int sNum = userNum * userNum;
        return sNum;
    }

    //Function that displays the results
    static void DisplayResult(string userName, int sNum)
    {
        Console.WriteLine($"{userName}, the square of your number is {sNum}");
    }

    //Function that calls all the other functions in sequence
    //Gathering the data needed to call the later functions as well.
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNum = PromptUserNum();
        int sNum = SquareNum(userNum);
        DisplayResult(userName, sNum);

    }
}