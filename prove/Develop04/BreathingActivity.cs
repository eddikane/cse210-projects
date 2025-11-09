using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing", "This activity will help you relax by guiding you through slow breathing. Clear your mind and focus on your breathing.")
    {
    }

    // This method overrides the Run method in the Activity class.
    public override void Run()
    {
        StartingMessage();
        Console.WriteLine(); 

        // The activity continues until the total time is reached.
        int tpassed = 0;

        while (tpassed < _duration)
        {
            Console.Write("Breathe in... ");
            ShowCountdown(4); 
            Console.WriteLine(); 
            Console.Write("Breathe out... ");
            ShowCountdown(6); 
            Console.WriteLine(); 
            tpassed += 10; // Each cycle (4 sec in, 6 sec out) takes ~10 seconds
        }

        EndingMessage();
    }
}