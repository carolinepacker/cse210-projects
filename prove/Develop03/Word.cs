using System;

public class Word
{
    // Member Variables
    private bool _visibility;
    private string _word;
    private string _originalWord;

    // Constructor
    public Word (string word)
    {
        _word = word;
        _originalWord = word;
        _visibility = true;
    }

    public void SetToHidden ()
    {
        _visibility = false;
        char[] wordAsChars = _word.ToCharArray();
        for (int i = 0; i < wordAsChars.Length; i++)
        {
            wordAsChars[i] = Convert.ToChar("_");
        }
        _word = String.Concat(wordAsChars);
    }

    public string GetWord ()
    {
        return _word;
    }

    public bool GetVisibility()
    {
        return _visibility;
    }

    public string GetOriginalWord()
    {
        return _originalWord;
    }
}