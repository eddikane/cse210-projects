using System;
using System.Collections.Generic; // Needed for List<Job>

public class Resume
{
    //Member Variables
    public string _name;
    public List<Job> _jobs = new List<Job>();
    

    // ----- Method -----
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}