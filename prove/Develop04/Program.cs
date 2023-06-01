using System;

class Program
{
    static void Main(string[] args)
    {
        

        //being menu loop
        string choice = "-1";
        while (choice != "4")
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("1. Start reflecting activity");
            Console.WriteLine("1. Start listing activity");
            Console.WriteLine("4. Quit");
            choice = Console.ReadLine();
            switch (choice)
            {
                case "1":

                    break;
                case "2":

                    break;
                case "3":
                    
                    break;
                default:
                    break;
            }
        }
    }
}