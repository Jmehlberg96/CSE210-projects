using System;


public class Activity
{
    protected DateTime _date;
    protected int _length;

    public Activity(DateTime date, int length)
    {
        _date = date;
        _length = length;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual string GetPace()
    {
        double pace = GetPaceInMinutes();
        int minutes = (int)Math.Floor(pace);
        int seconds = (int)Math.Round((pace - minutes) * 60);
        return $"{minutes:00}:{seconds:00} min/mi";
    }

    public double GetPaceInMinutes()
    {
        double distance = GetDistance();
        if (distance == 0)
        {
            return 0;
        }
        double timeInMinutes = _length / 60.0;
        double pace = timeInMinutes / distance;
        return pace;
    }
    public string DateToString()
    {
        string dateString = _date.ToString("dd MMM yyyy");
        return dateString;
    }

    public virtual string GetSummary()
    {
        return $"{DateToString()} ({_length} min) - Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace {GetPace()}";
    }
}
