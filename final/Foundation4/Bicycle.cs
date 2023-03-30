public class StationaryBicycle : Activity
{
    private double _speed;

    public StationaryBicycle(DateTime date, int length, double speed) : base(date, length)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return _speed * (_length / 60.0);
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override string GetPace()
    {
        if (_speed == 0)
        {
            return "N/A";
        }
        double pace = 60.0 / _speed;
        int minutes = (int)Math.Floor(pace);
        int seconds = (int)Math.Round((pace - minutes) * 60);
        return $"{minutes:00}:{seconds:00} min/mi";
    }

    public override string GetSummary()
    {
        return $"--------Bicycle Activity--------\n{DateToString()} Stationary Bicycle ({_length} min) - Speed {_speed:F1} mph, Distance {GetDistance():F1} miles, Pace: {GetPace()}\n";
    }
}
