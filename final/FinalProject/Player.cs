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
            return "No match data yet.\n";
        }

        int totalGoals = 0;
        int totalAssists = 0;
        double totalAccuracy = 0;

        for (int i = 0; i < _matches.Count; i++)
        {
            Match m = _matches[i];
            totalGoals += m.Goals;
            totalAssists += m.Assists;
            totalAccuracy += m.GetPassAccuracy();
        }

        double avgAccuracy = totalAccuracy / _matches.Count;

        string result = "";
        result += "Goals: " + totalGoals + "\n";
        result += "Assists: " + totalAssists + "\n";
        result += "Average Pass Accuracy: " + avgAccuracy + "%\n";

        return result;
    }

    public int GetRating()
    {
        if (_matches.Count == 0)
        {
            return 0;
        }

        int totalGoals = 0;
        double totalAccuracy = 0;

        for (int i = 0; i < _matches.Count; i++)
        {
            totalGoals += _matches[i].Goals;
            totalAccuracy += _matches[i].GetPassAccuracy();
        }

        double avgAccuracy = totalAccuracy / _matches.Count;

        // Simple beginner-friendly formula
        int rating = (totalGoals * 10) + (int)(avgAccuracy / 5);

        if (rating > 100)
        {
            rating = 100;
        }

        return rating;
    }
}
