using System;

class Comment
{
    private string _userName;
    private string _text;

    public Comment(string name, string text)
    {
        _userName = name;
        _text = text;
    }

    public string GetCommenterName()
    {
        return _userName;
    }

    public string GetText()
    {
        return _text;
    }
}