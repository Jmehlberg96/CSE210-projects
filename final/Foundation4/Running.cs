public class Running : Activity
{
    private double _distance;

    public Running(DateTime date, int length, double distance) : base(date, length)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        if (_distance == 0)
        {
            return 0;
        }
        return _distance / (_length / 60.0);
    }

    public override string GetPace()
    {
        double pace = GetPaceInMinutes();
        int minutes = (int)Math.Floor(pace);
        int seconds = (int)Math.Round((pace - minutes) * 60);
        return $"{minutes:00}:{seconds:00} min/mi";
    }

    public override string GetSummary()
    {
        return $"--------Running Activity--------\n{DateToString()} Running ({_length} min) - Distance {_distance:F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace()}\n";
    }
}
