using System;

class Program
{
    private static List<Goal> _goals = new List<Goal>();
    public static int totalPoints = 0;
    static void Main(string[] args)
    {
        string choice = "0";

        while (choice != "6")
        {
            string totalPointsString = totalPoints.ToString();
            Console.WriteLine($"You have {totalPointsString} points.");
            Console.WriteLine("");
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a Choice from the menu: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Clear();
                    CreateGoal();
                    break;

                case "2":
                    DisplayGoals();
                    break;

                case "3":
                    SaveFile();
                    break;

                case "4":
                    Console.WriteLine("What is the name of the file? ");
                    string filename = Console.ReadLine();
                    LoadFile(filename);
                    break;

                case "5":
                    RecordAnEvent();

                    break;

                case "6":
                    break;

            }
        }

        void CreateGoal()
        {
            string goalChoice;
            string goalName;
            string goalDesc;

            Console.WriteLine("The types of Goals are: ");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.WriteLine("Which type of goal would you like to create? ");
            goalChoice = Console.ReadLine();

            Console.WriteLine("What is the name of your goal? ");
            goalName = Console.ReadLine();
            Console.WriteLine("What is a short description of your goal? ");
            goalDesc = Console.ReadLine();
            Console.WriteLine("What is the amount of points associated with this goal? ");
            int goalPts = int.Parse(Console.ReadLine());

            switch(goalChoice)
            {
                // Simple Goal
                case "1":
                    SimpleGoal goal1 = new SimpleGoal("1", goalName, goalDesc, goalPts, false);
                    _goals.Add(goal1);
                    break;
                // Eternal Goal
                case "2":
                    EternalGoal goal2 = new EternalGoal("2", goalName, goalDesc, goalPts);
                    _goals.Add(goal2);
                    break;
                case "3":
                    Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
                    int repeatCount = int.Parse(Console.ReadLine());
                    Console.WriteLine("What is the bonus for accomplishing it that many times? ");
                    int bonusPts = int.Parse(Console.ReadLine());
                    ChecklistGoal goal3 = new ChecklistGoal("3", goalName, goalDesc, goalPts, repeatCount, bonusPts);
                    _goals.Add(goal3);
                    break;
                default:
                    break;
            }
        }
    }

    public static void UpdatePoints()
    {
        int totalScore = 0;
        for (int i = 0; i < _goals.Count(); i++)
        {
            totalScore += _goals[i].GetTotalPoints();
        }

        totalPoints = totalScore;

    }

    public static void DisplayGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals available.");
        }
        else 
        {
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].DisplayFormat()}");
            }
            Console.WriteLine("");
        }
        
    }

    public static void RecordAnEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals available.");
        }
        else 
        {
            Console.WriteLine("The goals are: ");
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].Name}");
            }
            Console.WriteLine("Which goal did you accomplish? ");
            string choice = Console.ReadLine();
            int choiceIndex = int.Parse(choice) - 1;
            _goals[choiceIndex].RecordEvent();
        }
        UpdatePoints();
    }

    public static void SaveFile()
    {
        Console.Write("What would you like to call the file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile  = new StreamWriter(filename))
        {
            outputFile.WriteLine(totalPoints);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.SaveFormat());
            }

            _goals.Clear();
        }
    }


    public static void LoadFile(string filename)
    {
        if (File.Exists(filename))
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                string line1;
                string line;
                line1 = reader.ReadLine();
                totalPoints = int.Parse(line1);

                while((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split("~~");
                    switch(parts[0])
                    {
                        case "1":
                            SimpleGoal goal1 = new SimpleGoal(parts[0], parts[1], parts[2], int.Parse(parts[3]), Convert.ToBoolean(parts[4]));
                            _goals.Add(goal1);
                            break;
                        case "2":
                            EternalGoal goal2 = new EternalGoal(parts[0], parts[1], parts[2], int.Parse(parts[3]));
                            _goals.Add(goal2);
                            break;
                        case "3":
                            ChecklistGoal goal3 = new ChecklistGoal(parts[0], parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]), int.Parse(parts[7]));
                            _goals.Add(goal3);
                            break;
                    }
                }
            }
        }
    }
}