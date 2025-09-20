using System;

class Program
{
    static void Main(string[] args)
    {
        //Creating an empty list
        List<int> numbers = new List<int>();

        //Create a loop that will go until 'wiggle' is changed
        bool wiggle = true;
        do
        {
            //Ask for user input and convert the data
            // so that it can go into our list
            Console.Write("Please Enter a Number: ");
            string response = Console.ReadLine();
            int entry = int.Parse(response);

            //Create a way to check if we are breaking the loop
            if (entry == 0)
            {
                wiggle = false;
            }

            else
            {
                //Add the Data to our List 'numbers'
                numbers.Add(entry);
            }

        } while (wiggle == true);

        //Give the user useful info about their list of numbers
        Console.WriteLine($"Sum: {numbers.Sum()}");
        Console.WriteLine($"Average: {numbers.Average()}");
        Console.WriteLine($"Largest: {numbers.Max()}");
    }
}