using System;

class Product
{
    private string _productName;
    private int _productId;
    private int _price;
    private int _quantity;

    public Product(string name, int id, int price, int amount)
    {
        _productName = name;
        _productId = id;
        _price = price;
        _quantity = amount;
    }

    public string GetName()
    {
        return _productName;
    }

    public int GetProductId()
    {
        return _productId;
    }

    public int GetPrice()
    {
        return _price;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public int GetTotalCost()
    {
        return _price * _quantity;
    }
}