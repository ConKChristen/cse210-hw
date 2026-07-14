using System;

class Order
{
    private List<Product> _products;
    private Customer _customers;

    public Order(Customer customer)
    {
        _customers = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public string GetPackingLabel()
    {
        string label = "";

        foreach (Product p in _products)
        {
            label += $"{p.GetName()} ({p.GetProductId()})\n";
        }

        return label;
    }

    public string GetShippingLabel()
    {
        return $"{_customers.GetName()}\n{_customers.GetAddress().GetAddress()}";
    }

    public double GetTotalCost()
    {
        double total = 0;

        foreach (Product p in _products)
        {
            total += p.GetTotalCost();
        }

        if (_customers.LiveUSA())
            total += 5;
        else
            total += 35;

        return total;
    }
}