using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isComplete = false;
    }

    public SimpleGoal(string name, string description, int points, bool isComplete, string lastDate)
        : base(name, description, points)
    {
        _isComplete = isComplete;
        _lastCompletedDate = lastDate;
    }

    public override int RecordEvent()
    {
        _isComplete = true;
        _lastCompletedDate = DateTime.Now.ToString("yyyy-MM-dd");
        return _points;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        string checkbox = _isComplete ? "[X]" : "[ ]";
        return $"{checkbox} {_name} ({_description}) -- Last completed: {_lastCompletedDate}";
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_name},{_description},{_points},{_isComplete},{_lastCompletedDate}";
    }
}

