using System;

public class Reference
{
    // Private Member Variables
    private string _book;
    private string _chapter;
    private string _verse;
    private bool _singleVerse;
    private string _endverse;

    // Constructors
    public Reference (string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _singleVerse = true;
        _endverse = "";
    }

    public Reference (string book, string chapter, string verse, string endverse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _singleVerse = false;
        _endverse = endverse;
    }

    public string DisplayReference () 
    {
        string displayFormat;
        if (_singleVerse)
        {
            displayFormat = $"{_book} {_chapter}:{_verse}";
        } else {
            displayFormat = $"{_book} {_chapter}:{_verse}-{_endverse}";
        }
        return displayFormat;
    }


}