using System.Collections;

public class Menu {

    //Attributes

    bool running = true;

    //Behaviors

    //Function that displays the menu until the user quits the system
    public void DisplayMenu()
    {
        Journal myJournal = new Journal();
        while (running)
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write Entry");
            Console.WriteLine("2. Read Entries");
            Console.WriteLine("3. Save Journal");
            Console.WriteLine("4. Load Journal");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                myJournal.AppendEntry();
                break;

                case "2":
                myJournal.DisplayJournal();
                break;

                case "3":
                myJournal.SaveJournal("journal.txt");
                break;

                case "4":
                myJournal.LoadJournal("journal.txt");
                break;

                case "5":
                running = false;
                Console.WriteLine("Thank you for writing today!");
                break;

                default:
                Console.WriteLine("Invalid Option. Please try again.");
                break;
            }

        }
    }

}