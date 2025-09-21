using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");


        Assignment test1 = new Assignment("Bockton", "software");
        Console.WriteLine(test1.GetSummary());
        Console.WriteLine();

        MathAssignment test2 = new MathAssignment("Jockton", "Software", "3.7", "1-22");
        Console.WriteLine(test2.GetSummary());
        Console.WriteLine(test2.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment test3 = new WritingAssignment("Lockton", "Software", "The Odyssey");
        Console.WriteLine(test3.GetSummary());
        Console.WriteLine(test3.GetWritingInfo());
        Console.WriteLine();
    }
}