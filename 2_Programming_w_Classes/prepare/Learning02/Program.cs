using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;
        
        Job job2 = new Job();
        job2._jobTitle = "CSR";
        job2._company = "Alta";
        job2._startYear = 2024;
        job2._endYear = 2025;


        Resume myresume = new Resume();
        myresume._userName = "Stockton";
        myresume._jobs.Add(job1);
        myresume._jobs.Add(job2);

        myresume.Display();
    }
}