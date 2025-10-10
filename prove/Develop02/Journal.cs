using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry e)
    {
        _entries.Add(e);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries yet.");
            return;
        }

        Console.WriteLine("\nYour Journal Entries:");
        Console.WriteLine("----------------------");
        foreach (Entry e in _entries)
        {
            Console.WriteLine(e);
        }
    }

    public void SaveToFile(string filename)
    {
        try
        {
            StreamWriter writer = new StreamWriter(filename);
            foreach (Entry e in _entries)
            {
                writer.WriteLine(e.SaveToFileString());
            }
            writer.Close(); // saves the data
            Console.WriteLine("Journal saved.");
        }
        catch (Exception error)
        {
            Console.WriteLine("Error saving file: " + error.Message);
        }
    }

    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        try
        {
            _entries.Clear(); // This clears the current list of journal entries so we start fresh before loading from a file
            string[] lines = File.ReadAllLines(filename); // Reads all the lines from the file into an array of strings
            foreach (string line in lines) // Loops through each line in the file
            {
                Entry entry = Entry.LoadFromFileString(line); // Turns the line of text back into an Entry object
                _entries.Add(entry); // Adds the new entry to the _entries list
            }
            Console.WriteLine("Journal loaded.");
        }
        catch (Exception error)
        {
            Console.WriteLine("Error loading file: " + error.Message);
        }
    }
}
