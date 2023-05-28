using System;

class Reference

{
    public Reference() {}
    public Reference(string book, string chapter, string verse, string content)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _content = content;
    }
    private string _book;
    private string _chapter;
    private string _verse;
    private string _content;
    

    public string GetBook()
    {
        return _book;
    }
    public void SetBook(string book)
    {
        _book = book;
    }
    public string GetChapter()
    {
        return _chapter;
    }
    public void SetChapter(string chapter)
    {
        _chapter = chapter;
    }
    public string GetVerse()
    {
        return _verse;
    }
    public void SetVerse(string verse)
    {
        _verse = verse;
    }
    public string GetContent()
    {
        return _content;
    }
    public void SetContent(string content)
    {
        _content = content;
    }
}