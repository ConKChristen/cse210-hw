using System;

class Program
{
    static void Main(string[] args)
    {
        Address ad1 = new Address("1515 Heights Valley", "Dallas", "TX", "USA");
        Address ad2 = new Address("1234 Main St", "Rexburg", "ID", "USA");
        Address ad3 = new Address("9876", "Toronto", "ON", "Canada");

        Customer cu1 = new Customer("Connor", ad1);
        Customer cu2 = new Customer("George", ad2);
        Customer cu3 = new Customer("Ally", ad3);

        Order o1 = new Order(cu1);
        Order o2 = new Order(cu2);
        Order o3 = new Order(cu3);

        o1.AddProduct(new Product("Laptop", 101, 700, 1));
        o1.AddProduct(new Product("Mouse", 102, 25, 2));
        o1.AddProduct(new Product("USB Cable", 103, 10, 3));

        o2.AddProduct(new Product("Desk Lamp", 201, 40, 1));
        o2.AddProduct(new Product("Notebook", 202, 5, 5));
        o2.AddProduct(new Product("Pen Pack", 203, 8, 2));

        o3.AddProduct(new Product("Dining Table", 301, 200, 1));
        o3.AddProduct(new Product("Window AC Unit", 302, 300, 1));
        o3.AddProduct(new Product("Salt and Pepper Shaker", 303, 2, 4));

        Console.WriteLine("ORDER 1");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(o1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(o1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${o1.GetTotalCost()}");
        Console.WriteLine("-------------");
        Console.WriteLine();


        Console.WriteLine("ORDER 2");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(o2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(o2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${o2.GetTotalCost()}");
        Console.WriteLine("-------------");
        Console.WriteLine();


        Console.WriteLine("ORDER 3");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(o3.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(o3.GetPackingLabel());
        Console.WriteLine($"Total Cost: ${o3.GetTotalCost()}");
        Console.WriteLine("-------------");
        Console.WriteLine();
    }
}