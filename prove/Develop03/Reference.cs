using System;

public class Reference
{
    private string _vs1;
    private string _bookName;
    private string _chapter;
    private string _vs2;
    public Reference()
    {
    }
    public Reference(string bookName, string chapter, string vs1)
    {
        _vs1 = vs1;
        _bookName =bookName;
        _chapter = chapter;
        _vs2 = "";  
    }
    public Reference(string bookName, string chapter, string vs1, string vs2)
    {
        _vs1 = vs1;
        _bookName = bookName;
        _chapter = chapter;
        _vs2 = vs2; 
    }
    public void DisplayReference()
    {
       Console.Write($"{_bookName} {_chapter}: {_vs1}");
       if(_vs2.Length > 0)
       {
        Console.Write($"-{_vs2}");
       }
    }
} 