using System;

public class Assignment
{
    private string _studentName;
    private string _topic;

    public Assignment(string name, string subject)
    {
        _studentName = name;
        _topic = subject;
    }

    // public string GetStudentName()
    // {
    //     return _studentName;
    // }

    // public string GetTopic()
    // {
    //     return _topic;
    // }

    public string GetSummary()
    {
        return $"Student Name: {_studentName} | Topic: {_topic}";
    }
}