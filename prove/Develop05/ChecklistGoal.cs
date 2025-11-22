using System;

public class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _targetCount;
    private int _bonusPoints;


    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
        _timesCompleted = 0;
    }

    public ChecklistGoal(string name, string description, int points, int timesCompleted, int targetCount, int bonusPoints, string lastDate)
        : base(name, description, points)
    {
        _timesCompleted = timesCompleted;
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
        _lastCompletedDate = lastDate;
    }

    public override int RecordEvent()
    {
        _timesCompleted++;
        _lastCompletedDate = DateTime.Now.ToString("yyyy-MM-dd");

        if (_timesCompleted == _targetCount)
        {
            return _points + _bonusPoints;
        }
        else
        {
            return _points;
        }
    }

    public override bool IsComplete()
    {
        return _timesCompleted >= _targetCount;
    }

    public override string GetDetailsString()
    {
        string checkbox = IsComplete() ? "[X]" : "[ ]";
        return $"{checkbox} {_name} ({_description}) -- Progress: {_timesCompleted}/{_targetCount} -- Last completed: {_lastCompletedDate}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_name},{_description},{_points},{_timesCompleted},{_targetCount},{_bonusPoints},{_lastCompletedDate}";
    }
}

