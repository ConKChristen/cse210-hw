using System;

class Program
{
    static void Main(string[] args)
    {
        Address addr1 = new Address("123 Main St", "Rexburg", "ID", "USA");
        Address addr2 = new Address("55 Maple Road", "Toronto", "ON", "Canada");
        Address addr3 = new Address("900 Beach Blvd", "San Diego", "CA", "USA");

        Event baseEvent1 = new Event("Tech Conference", "A conference about new software tools.", "Aug 15", "10:00 AM", addr1);

        Event baseEvent2 = new Event("Wedding Reception", "Celebration with family and friends.", "Sep 3", "6:00 PM", addr2);

        Event baseEvent3 = new Event("Summer Festival", "Outdoor fun with food and games.", "July 28", "12:00 PM", addr3);

        Lecture lecture = new Lecture("Tech Conference", "A conference about new software tools.", "Aug 15", "10:00 AM", addr1, "Dr. Smith", 150);
        Receptions reception = new Receptions("Wedding Reception", "Celebration with family and friends.", "Sep 3", "6:00 PM", addr2, "rsvp@wedding.com");
        OutdoorGathering outdoor = new OutdoorGathering("Summer Festival", "Outdoor fun with food and games.", "July 28", "12:00 PM", "Sunny with light breeze", addr3);

        Console.WriteLine("=== LECTURE EVENT ===");
        Console.WriteLine($"Standard Details: {lecture.GetStandardDetails()}");
        Console.WriteLine($"Full Details: {lecture.GetFullDetails()}");
        Console.WriteLine($"Short Details: {lecture.GetShortDetails()}");
        Console.WriteLine();

        Console.WriteLine("=== RECEPTION EVENT ===");
        Console.WriteLine($"Standard Details: {reception.GetStandardDetails()}");
        Console.WriteLine($"Full Details: {reception.GetFullDetails()}");
        Console.WriteLine($"Short Details: {reception.GetShortDetails()}");
        Console.WriteLine();

        Console.WriteLine("=== OUTDOOR GATHERING EVENT ===");
        Console.WriteLine($"Standard Details: {outdoor.GetStandardDetails()}");
        Console.WriteLine($"Full Details: {outdoor.GetFullDetails()}");
        Console.WriteLine($"Short Details: {outdoor.GetShortDetails()}");
        Console.WriteLine();
    }
}