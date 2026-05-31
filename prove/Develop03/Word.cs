using System;

class Word
{
    private string _word;
    private bool _hidden;

    // lines 9-13 is a Constructor 
    public Word(string word)
    {
        _word = word;
        _hidden = false;
    }

    // GetWordString - Return either the word, if not hidden, or the _s
    public string GetWordString()
    {
        string tempWord = "";
        if (_hidden)
        {
            foreach(char c in _word)
            {
                tempWord += '_';
            }
        }
        else
        {
            tempWord = _word;
        }
        return tempWord;
    }

    //Marks if the word is hidden
    public void Hide()
    {
        _hidden = true;
    }

    //Will let other classes check whether the word is hidden
    public bool IsHidden()
    {
        return _hidden;
    }

    public void DisplayWord()
    {
        Console.WriteLine(GetWordString());
    }
    
}