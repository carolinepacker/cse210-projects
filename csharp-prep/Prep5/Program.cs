using System;

class Program
{
    static void Main(string[] args)
    {

        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int numSquared = SquareNumber(number);
        DisplayResult(name, numSquared);
        
    }
    
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }        

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }    

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int favNum = int.Parse(Console.ReadLine());
        return favNum;
    }

    static int SquareNumber(int favNum)
    {
        int newNum = favNum * favNum;
        return newNum;
    }

     static void DisplayResult(string name, int squaredNum)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNum}");
    }
   

    
}