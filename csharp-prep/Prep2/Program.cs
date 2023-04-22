using System;

class Program
{
    static void Main(string[] args)
    {
        // Get User Input
        Console.WriteLine("Please enter your grade percentage: ");
        string userGrade = Console.ReadLine();
        int grade = int.Parse(userGrade);

        string letter = "";
        // Feed it into conditional statement
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade < 90 && grade >= 80)
        {
            letter = "B";
        }
        else if (grade < 80 && grade >= 70)
        {
            letter = "C";
        }
        else if (grade < 70 && grade >= 60)
        {
            letter = "D";
        }
        else if (grade < 60)
        {
            letter = "F";
        }
        else
        {
            Console.Write("I'm sorry, there was a problem with your entry.");
        }

        Console.Write($"Your letter grade is: {letter}");

        if (grade >= 70)
        {
            Console.Write("Congratulations! You passed the class!");
        }
        else
        {
            Console.Write("I'm sorry, you did not pass the class. Best of luck next time!");
        }
    }
}