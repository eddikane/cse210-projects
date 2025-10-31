using System;
using System.Reflection.Metadata.Ecma335;

public class Assignment
{
    private string _studentName;
    private string _topic;

    //Constructors
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetStudentName()
    {
        return _studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
    
}