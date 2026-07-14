using System;

class Customer
{
    private string _customerName;
    private Address _address;

    public Customer(string name, Address address)
    {
        _customerName = name;
        _address = address;
    }

    public bool LiveUSA()
    {
        return _address.IsUSA();
    }

    public Address GetAddress()
    {
        return _address;
    }

    public string GetName()
    {
        return _customerName;
    }
}