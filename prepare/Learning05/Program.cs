using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square sq1 = new Square(5, "Blue"); 
        shapes.Add(sq1);

        Rectangle rc1 = new Rectangle(5,6,"Green");
        shapes.Add(rc1);

        Circle cr1 = new Circle(3, "Red");
        shapes.Add(cr1);

        foreach (Shape s in shapes)
        {
            // Notice that all shapes have a GetColor method from the base class
            string color = s.GetColor();

            // Notice that all shapes have a GetArea method, but the behavior is
            // different for each type of shape
            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}