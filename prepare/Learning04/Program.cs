using System;

class Program
{
    static void Main(string[] args)
    {
        WritingAssignment assignment1 = new WritingAssignment("Caroline Packer", "World History", "World War II");
        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine(assignment1.GetWritingInformation());
    }
}