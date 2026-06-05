using System;

public class WrittingAssignment : Assignment
{
    //shares _studentName and _topic
    private string _title;

    public WrittingAssignment(string name, string subject, string title) : base(name, subject)
    {
        _title = title;
    }

    public string GetWrittingInformation()
    {
        return $"Title: {_title}";
    }
}