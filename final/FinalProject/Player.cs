using System;
using System.Collections.Generic;

public abstract class Player
{
    private string _name;
    private int _age;
    private string _position;

    private List<Match> _matches = new List<Match>();

    public Player(string name, int age, string position)
    {
        _name = name;
        _age = age;
        _position = position;
    }

    public void AddMatch(Match m)
    {
        _matches.Add(m);
    }

    public virtual string GetWeaknesses()
    {
        return "General improvement needed.";
    }

    public string GetStats()
    {
        if (_matches.Count == 0)
        {
            return "No matches recorded.\n";
        }

        int totalGoals = 0;
        int totalAssists = 0;
        double totalAccuracy = 0;

        foreach (Match m in _matches)
        {
            totalGoals += m.Goals;
            totalAssists += m.Assists;
            totalAccuracy += m.GetPassAccuracy();
        }

        double avgAccuracy = totalAccuracy / _matches.Count;

        string result = "";
        result += "Total Goals: " + totalGoals + "\n";
        result += "Total Assists: " + totalAssists + "\n";
        result += "Average Pass Accuracy: " + avgAccuracy + "%\n";

        return result;
    }
}
