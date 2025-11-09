using System;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration; 

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
    }

    public void StartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} activity!\n");
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long would you want your session to last? (in seconds): ");
        string input = Console.ReadLine();
        _duration = int.Parse(input); // Convert the input into a number.
        Console.WriteLine("\nLet us begin...");
        ShowSpinner(3); 
    }

    public void EndingMessage()
    {
        Console.WriteLine("\nWell done!!");
        Console.WriteLine($"\nYou have completed {_duration} seconds of the {_name} activity.");
        ShowSpinner(2);
    }

    protected void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };

        for (int i = 0; i < seconds; i++)
        {
            // Loop through each spinner character.
            foreach (string s in spinner)
            { //this creates the illusion of the characters spinning in place
                Console.Write(s);        // Print the spinner symbol
                Thread.Sleep(250);       // Wait 1/4 second - 250miliseconds is 1/4sec
                Console.Write("\b \b");  // Erase it (backspace trick)
            }
        }
    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);     // Print the number
            Thread.Sleep(1000);   // Wait 1 second
            Console.Write("\b \b"); // Erases the number before the next one prints
        }
    }

    public virtual void Run()
    {
        // derived classes will replace this with their own instructions.
    }
    }
