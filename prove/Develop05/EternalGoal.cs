using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }
    public EternalGoal(string name, string description, int points, string lastDate)
        : base(name, description, points)
    {
        _lastCompletedDate = lastDate;
    }

    public override int RecordEvent()
    {
        _lastCompletedDate = DateTime.Now.ToString("yyyy-MM-dd");
        return _points;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetailsString()
    {
        return $"[∞] {_name} ({_description}) -- Last completed: {_lastCompletedDate}";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_name},{_description},{_points},{_lastCompletedDate}";
    }
}

