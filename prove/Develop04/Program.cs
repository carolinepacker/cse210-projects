using System;

class Program
{

    static void Main(string[] args)
    {
        string breathingActivityDesc = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        string reflectingActivityDesc = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        string listingActivityDesc = "This activity will hlep you reflect on the good things in your life by having you list as many things as you can in a certain area.";

        //being menu loop
        string choice = "-1";
        while (choice != "4")
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            choice = Console.ReadLine();
            Console.Clear();
            switch (choice)
            {
                case "1":
                    BreathingActivity breathing1 = new BreathingActivity("Breathing Activity", breathingActivityDesc);
                    breathing1.WelcomeMessage();
                    Console.Clear();
                    breathing1.GetReadyMessage();
                    breathing1.BreathingCycle();
                    breathing1.EndMessage();
                    Console.Clear();
                    break;
                case "2":
                    ReflectingActivity reflecting1 = new ReflectingActivity("Reflecting Activity", reflectingActivityDesc);
                    reflecting1.WelcomeMessage();
                    Console.Clear();
                    reflecting1.GetReadyMessage();
                    reflecting1.ReflectingMenu();
                    Console.Clear();
                    reflecting1.ReflectingCycle();
                    reflecting1.EndMessage();
                    Console.Clear();
                    break;
                case "3":
                    ListingActivity listing1 = new ListingActivity("Listing Activity", listingActivityDesc);
                    listing1.WelcomeMessage();
                    Console.Clear();
                    listing1.GetReadyMessage();
                    listing1.ListingCycle();
                    listing1.EndMessage();
                    Console.Clear();
                    break;
                default:
                    break;
            }
        }
    }
}