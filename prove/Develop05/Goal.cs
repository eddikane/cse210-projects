using System;

public class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected string _lastCompletedDate;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _lastCompletedDate = "Never";
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetPoints()
    {
        return _points;
    }

    public virtual int RecordEvent()
    {
        return 0;
    }

    public virtual bool IsComplete()
    {
        return false;
    }

    public virtual string GetDetailsString()
    {
        return $"{_name} ({_description}) -- Last completed: {_lastCompletedDate}";
    }

    public virtual string GetStringRepresentation()
    {
        return $"Goal:{_name},{_description},{_points},{_lastCompletedDate}";
    }
}

