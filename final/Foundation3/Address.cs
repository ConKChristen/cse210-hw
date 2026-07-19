using System;

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string streetAddy, string city, string stateProvinance, string country)
    {
        _street = streetAddy;
        _city = city;
        _state = stateProvinance;
        _country = country;
    }

    public string GetAddress()
    {
        return $"{_street} {_city}, {_state} {_country}";
    }
}