using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop02 World! We did it!");

        //For the exceed I decided to make an extra class just for the menu
        //In the Menu class I've added a switch statement to make it organized
        //This way if I ever add to this program the main function will still be very simple

        Menu theMenu = new Menu();

        theMenu.DisplayMenu();
    }
}