using System;
using System.Collections.Generic;
using System.Threading;

public class GratitudeActivity : Activity
{
    private List<string> _gratitudePrompts;

    public GratitudeActivity()
        : base("Gratitude", "This activity helps you reflect on the blessings in your life and recognize the positive things around you.")
    {
        _gratitudePrompts = new List<string>()
        {
            "What are three things you’re grateful for today?",
            "Who made your day better recently?",
            "What is something you often take for granted but appreciate now?",
            "What small thing are you thankful for that you usually overlook?",
            "Who has had a positive influence on your life?"
        };
    }

    public override void Run()
    {
        StartingMessage();
        Console.WriteLine();
        Console.WriteLine("Let's take a moment to think about gratitude.");
        Console.WriteLine();
        Random random = new Random();
        string prompt = _gratitudePrompts[random.Next(_gratitudePrompts.Count)];
        Console.WriteLine($"{prompt}");
        Console.WriteLine();
        Console.Write("You may begin in: ");
        ShowCountdown(5);
        Console.WriteLine();

        List<string> responses = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            responses.Add(response);
        }

        Console.WriteLine();
        Console.WriteLine("✨ Here's what you were grateful for today: ✨");
        Console.WriteLine("------------------------------------------");
        foreach (string r in responses)
        {
            Console.WriteLine($"• {r}");
        }

        Console.WriteLine($"\nYou listed {responses.Count} things to be grateful for!");
        EndingMessage();
    }
}
