using System;
using System.Net;
using System.Reflection.PortableExecutable;

class Program
{
    static void Main(string[] args)
    {
        // Creates random number starting with 1 and ending at 10
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        bool machinas = true;

        //A while loop that asks the user for a guess after each attempt
        while (machinas == true)
        {
            //Asking for the user prompt and converting it to an int.
            //If you guess correctly the loop ends
            Console.Write("Try to guess the Magic Number: ");
            string response = Console.ReadLine();
            int guess = int.Parse(response);

            //Checking to see if the guess is higher, lower, or correct
            if (guess > number)
            {
                Console.WriteLine("Lower!");
            }

            else if (guess < number)
            {
                Console.WriteLine("Higher!");
            }

            else
            {
                Console.WriteLine("Congrats!");
                Console.WriteLine($"The number is {number}");
                machinas = false;
            }
        }
    }
}