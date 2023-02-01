using System.IO;

public class Entry
{
    public string _date;
    public string _response;
    public string _prompt;
    public void EntryDetails()
    {
        Console.WriteLine($"{_date}; {_prompt}");
        Console.WriteLine($"{_response}");
    }
    public string GetRandomPrompt()
    {
        var random = new Random();
        var prompts = new List<string>{
            "What was the best part of your day?",
            "How did you see the hand of the Lord in your day today?",
            "What did you learn in your studies today?",
            "Who helped you the most today?",
            "What happened in the world today?",
            "Who influences you the most?",
            "What is one of your greatest blessings and why?"
            };
        int index = random.Next(prompts.Count);
        _prompt = prompts[index];
        return _prompt;
    }
    public string DisplayDate()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        return dateText;
    }


}








