using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job(); // create new 'Job' object
        job1._company = "Temecula Stoneworks"; // assign properties to object
        job1._jobTitle = "Owner";
        job1._startYear = 1999;
        job1._endYear = 2014;

        Job job2 = new Job();
        job2._company = "Garden Isle Divers";
        job2._jobTitle = "Owner";
        job2._startYear = 2016;
        job2._endYear = 2023;

        //job1.Display(); -->commented out as an obsolete step
        //job2.Display();

        Resume myResume = new Resume(); // create new 'Resume' object
        myResume._name = "Eric Shewchuk";
        myResume._jobs.Add(job1); // add 'Job' objects into the list created by 'Resume'
        myResume._jobs.Add(job2);

        myResume.Display(); 
    }
}