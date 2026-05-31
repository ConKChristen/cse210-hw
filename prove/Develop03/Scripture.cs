using System;
using System.Security.Cryptography;
class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        //I need to make the full sting be turned into indivdual work strings
        string[] parts = text.Split(" ");
        foreach (string part in parts)
        {
            _words.Add(new Word(part));
        }
    }

   public void HideWords()
    {
        Random rad = new Random();
        bool hiddenOne = false;

        while (!hiddenOne)
        {
            int index = rad.Next(_words.Count);

            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenOne = true;
            }
        }
    }
    public string GetText()
    {
        string result = "";

        for (int i = 0; i < _words.Count; i++)
        {
            result += _words[i].GetWordString();

            if (i < _words.Count - 1)
            {
                result += " ";
            }
        }

        return result;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word w in _words)
        {
            if (w.IsHidden() == false)
            {
                return false;
            }
        }

        return true;
    }
}