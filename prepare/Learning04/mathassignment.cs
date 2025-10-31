using System;

public class mathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    //Constructor
    public mathAssignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName, topic) // Call the base class constructor
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetTextbookSection()
    {
        return _textbookSection;
    }

    public string GetProblems()
    {
        return _problems;
    }

    // Method to return the homework details
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
    
}