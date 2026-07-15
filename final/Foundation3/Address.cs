using System;

class Address
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
}