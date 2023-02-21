using System;

public class ReflectingGen{

    private List<string> promptList = new List<string>();

    public ReflectingGen()
    {
        promptList.Add("---Think of a time when you stood up for someone else.---");
        promptList.Add("---Think of a time when you did something really difficult.---");
        promptList.Add("---Think of a time when you helped someone in need.---");
        promptList.Add("---Think of a time when you did something truly selfless.---");   
    }
    public string PullRandomPrompt()
    {
        var countPrompt = promptList.Count();
        Random random = new Random();
        int randomInt = random.Next(0,countPrompt -1);
        string promptQ = promptList[randomInt];
        promptList.Remove(promptQ);
        return promptQ;
    }


}