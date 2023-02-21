using System;

public class QuestionGen
{
    private List<string>_questionList = new List<string>();
    
    public QuestionGen()
    {
        _questionList.Add("---Why was this experience meaningful to you?---");
        _questionList.Add("---Have you ever done anything like this before?---");
        _questionList.Add("---How did you get started?---");
        _questionList.Add("---How did you feel when it was complete?---");
        _questionList.Add("---What made this time different than other times when you were not as successful?---");
        _questionList.Add("---What is your favorite thing about this experience?---");
        _questionList.Add("---What could you learn from this experience that applies to other situations?---");
        _questionList.Add("---What did you learn about yourself through this experience?---");
        _questionList.Add("---How can you keep this experience in mind in the future?---");
    }

    public string GetRandomQuestion()
    {
        var countQuestion = _questionList.Count();
        Random random = new Random();
        int randomInt = random.Next(0, countQuestion -1);
        string _question = _questionList[randomInt];
        _questionList.Remove(_question);
        return _question;
    }
} 