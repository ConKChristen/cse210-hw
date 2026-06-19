using System;

public class Rectangle : Shape
{
    private double _length;
    private double _width;

    public Rectangle(int lenght, int width, string color) : base(color)
    {
        _length = lenght;
        _width = width;
    }

    public override double GetArea()
    {
        return _length * _width;
    }
}