public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int length, int laps) : base(date, length)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50.0 / 1000 * 0.62; // convert laps to miles
    }

    public override double GetSpeed()
    {
        if (_length == 0)
        {
            return 0;
        }
        return GetDistance() / (_length / 60.0);
    }

    public override string GetPace()
    {
        if (_length == 0 || GetDistance() == 0)
        {
            return "N/A";
        }
        double pace = (_length / 60.0) / GetDistance();
        int minutes = (int)Math.Floor(pace);
        int seconds = (int)Math.Round((pace - minutes) * 60);
        return $"{minutes:00}:{seconds:00} min/100m";
    }

    public override string GetSummary()
    {
        return $"{DateToString()} Swimming ({_length} min)- {_laps} laps, Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace {GetPace()}";
    }
}
