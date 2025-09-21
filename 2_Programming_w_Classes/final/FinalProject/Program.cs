using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello FinalProject World!");
        
        //Debug Sounds

        //Console.WriteLine("Current Directory: " + Directory.GetCurrentDirectory());
        //Area test1 = new Area(0, false, false, false, false, false, false, false, false, false);
        //if (!File.Exists("the_river.wav"))
        //{
        //    Console.WriteLine("File not found!");
        //}
        //else
        //{
        //    bool running = true;
        //    int go = 0;
        //    Console.WriteLine("File found!");
        //    while(running)
        //    {
        //        if(go == 1)
        //        {
        //            running = false;
        //        }
        //        else
        //        {
        //            test1.PlaySound("the_river.wav");
        //            test1.PrintResponse("describe_river");
        //            Thread.Sleep(10000);
        //            go += 1;
        //        }
        //    }
        //}

        MainMenu gamestart = new MainMenu();
        gamestart.Start();

    }
}