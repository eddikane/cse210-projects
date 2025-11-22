using System;
using System.Collections.Generic;
using System.IO;

// Showing Creativity: Added a "last completed date" feature to exceed requirements.
// Each time the user records progress on any goal, the system saves the current date and displays it in the goal details.


public class Program
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void Start()
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine($"\nYou have {_score} points.\n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Record Event");
            Console.WriteLine("  4. Save Goals");
            Console.WriteLine("  5. Load Goals");
            Console.WriteLine("  6. Quit");

            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": CreateGoal(); break;
                case "2": ListGoals(); break;
                case "3": RecordGoalEvent(); break;
                case "4": SaveGoals(); break;
                case "5": LoadGoals(); break;
                case "6": running = false; break;
            }
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("\nTypes of Goals:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");

        Console.Write("Which type? ");
        string type = Console.ReadLine();

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string desc = Console.ReadLine();

        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
        {
            _goals.Add(new SimpleGoal(name, desc, points));
        }
        else if (type == "2")
        {
            _goals.Add(new EternalGoal(name, desc, points));
        }
        else if (type == "3")
        {
            Console.Write("Target count: ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("Bonus points: ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
        }
    }

    public void ListGoals()
    {
        Console.WriteLine("\nYour Goals:");
        int index = 1;
        foreach (Goal g in _goals)
        {
            Console.WriteLine($"{index}. {g.GetDetailsString()}");
            index++;
        }
    }

    public void RecordGoalEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("You have no goals yet.");
            return;
        }

        ListGoals();
        Console.Write("\nWhich goal did you complete? ");
        int choice = int.Parse(Console.ReadLine());

        if (choice < 1 || choice > _goals.Count)
        {
            Console.WriteLine("Invalid choice.");
            return;
        }

        Goal g = _goals[choice - 1];

        int earned = g.RecordEvent();
        _score += earned;

        Console.WriteLine($"You earned {earned} points!");
    }

    public void SaveGoals()
    {
        Console.Write("Filename: ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            // First line: score
            outputFile.WriteLine(_score);

            // Then each goal on its own line
            foreach (Goal g in _goals)
            {
                outputFile.WriteLine(g.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved.");
    }

    public void LoadGoals()
    {
        Console.Write("Filename: ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);
        if (lines.Length == 0)
        {
            Console.WriteLine("File is empty.");
            return;
        }

        _score = int.Parse(lines[0]);
        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(':');
            string type = parts[0];
            string[] data = parts[1].Split(',');

            string name = data[0];
            string desc = data[1];
            int points = int.Parse(data[2]);

            if (type == "SimpleGoal")
            {
                bool complete = bool.Parse(data[3]);
                string lastDate = data[4];

                SimpleGoal sg = new SimpleGoal(name, desc, points, complete, lastDate);
                _goals.Add(sg);
            }
            else if (type == "EternalGoal")
            {
                string lastDate = data[3];

                EternalGoal eg = new EternalGoal(name, desc, points, lastDate);
                _goals.Add(eg);
            }
            else if (type == "ChecklistGoal")
            {
                int times = int.Parse(data[3]);
                int target = int.Parse(data[4]);
                int bonus = int.Parse(data[5]);
                string lastDate = data[6];

                ChecklistGoal cg = new ChecklistGoal(name, desc, points, times, target, bonus, lastDate);
                _goals.Add(cg);
            }
        }

        Console.WriteLine("Goals loaded.");
    }

    public static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }
}

