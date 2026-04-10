using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;
    private string _filename = "goals.txt";

    public void Start()
    {
        LoadGoals(); // Auto-load if file exists

        while (true)
        {
            Console.Clear();
            DisplayPlayerInfo();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Record Event");
            Console.WriteLine("  4. Save Goals");
            Console.WriteLine("  5. Load Goals");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalDetails();
                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadLine();
                    break;
                case "3":
                    RecordEvent();
                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadLine();
                    break;
                case "4":
                    SaveGoals();
                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadLine();
                    break;
                case "5":
                    LoadGoals();
                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadLine();
                    break;
                case "6":
                    Console.WriteLine("Thanks for using Eternal Quest! Goodbye.");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Press Enter to try again.");
                    Console.ReadLine();
                    break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        int level = (_score / 1000) + 1;
        string title = GetLevelTitle(level);
        int progress = _score % 1000;
        Console.WriteLine($"You have {_score} points.");
        Console.WriteLine($"You are at Level {level}: {title}");
        Console.WriteLine($"Progress to next level: {progress}/1000 points");
        Console.WriteLine();
    }

    private string GetLevelTitle(int level)
    {
        return level switch
        {
            1 => "Beginner Seeker",
            2 => "Faithful Follower",
            3 => "Scripture Scholar",
            4 => "Temple Warrior",
            5 => "Ninja Unicorn",
            6 => "Eternal Champion",
            _ => $"Legendary Quest Master {level}"
        };
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string type = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        Goal newGoal = null;

        if (type == "1")
        {
            newGoal = new SimpleGoal(name, description, points);
        }
        else if (type == "2")
        {
            newGoal = new EternalGoal(name, description, points);
        }
        else if (type == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus points for completing it? ");
            int bonus = int.Parse(Console.ReadLine());
            newGoal = new ChecklistGoal(name, description, points, target, bonus);
        }

        if (newGoal != null)
        {
            _goals.Add(newGoal);
            Console.WriteLine("Goal created successfully!");
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        if (_goals.Count == 0)
        {
            Console.WriteLine("   No goals yet.");
            return;
        }
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"  {i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void RecordEvent()
    {
        ListGoalDetails();
        Console.Write("Which goal did you accomplish? ");
        if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= _goals.Count)
        {
            int index = choice - 1;
            Goal goal = _goals[index];

            int pointsEarned = goal.RecordEvent();
            if (pointsEarned > 0)
            {
                int oldLevel = (_score / 1000) + 1;
                _score += pointsEarned;
                int newLevel = (_score / 1000) + 1;

                Console.WriteLine($"Congratulations! You earned {pointsEarned} points!");

                if (newLevel > oldLevel)
                {
                    string title = GetLevelTitle(newLevel);
                    Console.WriteLine($"🎉 LEVEL UP! You are now Level {newLevel}: {title}!");
                }
            }
            else
            {
                Console.WriteLine("This goal is already completed and cannot be recorded again.");
            }
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }

    public void SaveGoals()
    {
        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved successfully!");
    }

    public void LoadGoals()
    {
        if (!File.Exists(_filename))
        {
            return; // first run is normal
        }

        string[] lines = File.ReadAllLines(_filename);
        if (lines.Length == 0) return;

        _score = int.Parse(lines[0]);
        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');
            string goalType = parts[0];

            if (goalType == "SimpleGoal")
            {
                _goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4])));
            }
            else if (goalType == "EternalGoal")
            {
                _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
            }
            else if (goalType == "ChecklistGoal")
            {
                _goals.Add(new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]),
                    int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6])));
            }
        }
        Console.WriteLine("Goals loaded successfully!");
    }
}