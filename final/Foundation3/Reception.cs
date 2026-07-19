using System;

class Receptions : Event
{
    private string _rsvpEmail;

    public Receptions(string title, string description, string date, string time, Address address, string rsvp) : base (title, description, date, time, address)
    {
        _rsvpEmail = rsvp;
    }

    public string GetFullDetails()
    {
        return $"{GetStandardDetails()} || RSVP Email: {_rsvpEmail}";
    }

    public string GetShortDetails()
    {
        return GetShortDetails("Reception");
    }
}