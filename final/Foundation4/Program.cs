using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine();
        // Create a list of activities
        List<Activity> activities = new List<Activity>();

        // Add a running activity
        DateTime runningDate = new DateTime(2022, 11, 3);
        int runningLength = 30;
        double runningDistance = 3.0;
        Activity running = new Running(runningDate, runningLength, runningDistance);
        activities.Add(running);

        // Add a stationary bicycle activity
        DateTime bikeDate = new DateTime(2022, 11, 4);
        int bikeLength = 45;
        double bikeSpeed = 15.0;
        Activity bike = new StationaryBicycle(bikeDate, bikeLength, bikeSpeed);
        activities.Add(bike);

        // Add a swimming activity
        DateTime swimDate = new DateTime(2022, 11, 5);
        int swimLength = 60;
        int swimLaps = 20;
        Activity swimming = new Swimming(swimDate, swimLength, swimLaps);
        activities.Add(swimming);

        // Iterate through the activities and display the summaries
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
        Console.WriteLine("");
    }
}
