using System;

class Word
// Keep track of words hidden and not hidden
{
    private string _word;
    private bool _isShown;

    public Word() {}
    public Word(string word)
    {
        _word = word;
    }
    public Word(string word, bool isShown)
    {
        _word = word;
        _isShown = isShown;
    }
    public string GetWord()
    {
        return _word;
    }
    public void SetWord(string word)
    {
        _word = word;
    }
    public bool GetIsShown()
    {
        return _isShown;
    }
    public void SetIsShown(bool Shown)
    {
        _isShown = Shown;
    }
}