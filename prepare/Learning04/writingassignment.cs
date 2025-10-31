public class WritingAssignment : Assignment
{
    private string _title;

    // Constructor
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic) // Call base class constructor
    {
        _title = title;
    }

    public string GetTitle()
    {
        return _title;
    }

    // Method to return writing information
    public string GetWritingInformation()
    {
        // Access student name through the base class getter
        string studentName = GetStudentName();

        return $"{_title} by {studentName}";
    }
}
