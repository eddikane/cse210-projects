using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the best meal you had today?",
        "If I had one thing I could do over today, what would it be?",
        "What am I most grateful for today?",
        "What challenge did I overcome today?"
    };

    public Random _random = new Random();  // This creates the random number generator

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);  // Returns a random prompt from the 7 available options
        return _prompts[index];
    }
}
