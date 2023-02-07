using System;

class Program
{    
    static void Main(string[] args)
    {
        string bookName = "Proverbs";
        string chapter = "3";
        string vs1 = "5";
        string vs2 = "6 ";
        string text1 = "Trust in the Lord with all thine heart; and lean not unto thine own understanding.";
        string text2 = " In all thy ways acknowledge him, and he shall direct thy paths.";
        Scripture scripture = new Scripture(bookName,chapter,vs1,vs2,text1,text2);
        scripture.GetReference().DisplayReference();
        scripture.GetRenderedText();
        Console.WriteLine("\n");
        Console.WriteLine("Hit enter to hide words or type 'quit' to end program."); 
        string response = Console.ReadLine();
        while(response != "quit")
        { 
            if(!scripture.IsCompletelyHidden())
            {
                scripture.HideRandomWord();
            }
            if(!scripture.IsCompletelyHidden())
            {
                scripture.HideRandomWord();
            }
            if(!scripture.IsCompletelyHidden())
            {
                scripture.HideRandomWord();
            }
            Console.Clear();
            scripture.GetReference().DisplayReference();
            scripture.GetRenderedText();
            response = Console.ReadLine(); 
            if (scripture.IsCompletelyHidden())
            {
                response = "quit";
            }
        }  
    }
}