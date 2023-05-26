using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private int _eraseCount = 0;
    private Random _random = new Random();
    private List<Int32> _usedIndexes = new List<Int32>();

    // Constructors
    public Scripture (string book, string chapter, string verseNum, string wholeVerse)
    {
        _reference = new Reference(book, chapter, verseNum);
        List<String> scriptureWordList = wholeVerse.Split(" ").ToList();
        foreach(string scriptureWord in scriptureWordList)
        {
            Word newWord = new Word(scriptureWord);
            _words.Add(newWord);
        }
    }

    public Scripture (string book, string chapter, string verseNum, string endverseNum, string wholeVerse)
    {
        _reference = new Reference(book, chapter, verseNum, endverseNum);
        List<String> scriptureWordList = wholeVerse.Split(" ").ToList();
        foreach(string scriptureWord in scriptureWordList)
        {
            Word newWord = new Word(scriptureWord);
            _words.Add(newWord);
        }
    }

    public string DisplayVerse()
    {
        List<String> wordList = new List<string>();
        foreach (Word word in _words)
        {
            string displayWord = word.GetWord();
            wordList.Add(displayWord);
        }
        string wholeVerse = string.Join(" ", wordList);
        return wholeVerse;
    }

    public string DisplayScripture()
    {
        string wholeVerse = DisplayVerse();
        string wholeRef = _reference.DisplayReference();
        return $"{wholeRef} {wholeVerse}";
    }

    public void EraseWord()
    {
        bool used = true;
        while (used)
        {
            int wordIndex = _random.Next(_words.Count());
            if (!_usedIndexes.Contains(wordIndex))
                {
                    _words[wordIndex].SetToHidden();
                    _eraseCount++;
                    _usedIndexes.Add(wordIndex);
                    used = false;
                } 
        }
        
        
    }

    public int GetEraseCount()
    {
        return _eraseCount;
    }

    public List<Word> GetWords()
    {
        return _words;
    }
}