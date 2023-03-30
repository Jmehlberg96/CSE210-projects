using System;

public class Program
{
    public static void Main()
    {
        Console.Clear();
        Address address1 = new Address("101 N Main St", "San Diego", "CA", "95401");
        Address address2 = new Address("459 Maple Ave", "Mesa", "AZ", "85203");
        Address address3 = new Address("717 E Elm St", "San Antonio", "TX", "72024");

        Lecture lecture = new Lecture("5 Messages", "Five messages that all Gods children need to hear.", new DateTime(2023, 4, 15), new TimeSpan(13, 0, 0), address1, "Dieter F Uchtdorf", 50);
        Reception reception = new Reception("Nathan Scott and Kaia Mehlberg Wedding", "Come celebrate with the newly married couple and enjoy food, fun, and music.", new DateTime(2023, 5, 1), new TimeSpan(18, 0, 0), address2, "rsvp@company.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Community Picnic", "Bring your family and friends for a fun-filled day of games and food.", new DateTime(2023, 6, 10), new TimeSpan(11, 0, 0), address3, "Sunny and warm");

        Console.WriteLine("Lecture:\n");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine("\n__________________________________________________\n");

        Console.WriteLine("Reception:\n");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine("\n__________________________________________________\n");

        Console.WriteLine("Outdoor Gathering:\n");
        Console.WriteLine(outdoorGathering.GetStandardDetails());
        Console.WriteLine(outdoorGathering.GetFullDetails());
        Console.WriteLine(outdoorGathering.GetShortDescription());
        Console.WriteLine("\n__________________________________________________\n");
    }
}
