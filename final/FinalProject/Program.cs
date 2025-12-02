using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Soccer Performance Tracker ===");

        Player player = CreatePlayer();

        string choice = "";
        while (choice != "4")
        {
            Console.WriteLine();
            Console.WriteLine("1. Add Match");
            Console.WriteLine("2. View Stats");
            Console.WriteLine("3. Generate Training Plan");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                AddMatch(player);
            }
            else if (choice == "2")
            {
                Console.WriteLine(player.GetStats());
            }
            else if (choice == "3")
            {
                TrainingPlanner planner = new TrainingPlanner();
                List<TrainingDrill> plan = planner.GeneratePlan(player);

                Console.WriteLine("Training Plan:");
                foreach (TrainingDrill drill in plan)
                {
                    Console.WriteLine(drill.PerformDrill());
                }
            }
            else if (choice == "4")
            {
                Console.WriteLine("Exiting...");
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
    }

    static Player CreatePlayer()
    {
        Console.WriteLine();
        Console.Write("Enter player name: ");
        string name = Console.ReadLine();

        Console.Write("Enter age: ");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine("Position:");
        Console.WriteLine("1. Striker");
        Console.WriteLine("2. Midfielder");
        Console.WriteLine("3. Defender");
        Console.Write("Choose: ");
        string option = Console.ReadLine();

        if (option == "1")
        {
            return new Striker(name, age);
        }
        else if (option == "2")
        {
            return new Midfielder(name, age);
        }
        else
        {
            return new Defender(name, age);
        }
    }

    static void AddMatch(Player player)
    {
        Console.Write("Goals: ");
        int g = int.Parse(Console.ReadLine());

        Console.Write("Assists: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Passes Completed: ");
        int pc = int.Parse(Console.ReadLine());

        Console.Write("Passes Attempted: ");
        int pa = int.Parse(Console.ReadLine());

        Match m = new Match(g, a, pc, pa);
        player.AddMatch(m);

        Console.WriteLine("Match added!");
    }
}
