using System;

class OutdoorGathering : Event
{
    private string _weatherForcast;

    public OutdoorGathering(string title, string description, string date, string time, string weather, Address address) : base (title, description, date, time, address)
    {
        _weatherForcast = weather;
    }

    public string GetFullDetails()
    {
        return $"{GetStandardDetails()} || Weather Forcast: {_weatherForcast}";
    }
    public string GetShortDetails()
    {
        return GetShortDetails("Outdoor Gathering");
    }
}