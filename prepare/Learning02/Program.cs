using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1  = new Job();
        job1._company = "Apple";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2004;
        job1._endYear = 2014;

        Job job2 = new Job();
        job2._company = "Google";
        job2._jobTitle = "CEO";
        job2._startYear = 2020;
        job2._endYear = 2023;

        Resume resume1 = new Resume();
        resume1._name = "Caroline Nielson";

        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.Display();
    }

}