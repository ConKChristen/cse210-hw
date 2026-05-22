using System;

class Program
{
    static void Main(string[] args)
    {
        // Practice the principle of encapsulation by creating classes to hold a fraction, such as 2/3. As you recall from your Math classes, 

        // f1 - f3 = Constructor test
        Fraction f1 = new Fraction ();
        Fraction f2 = new Fraction (6);
        Fraction f3 = new Fraction (6 , 7);

        Fraction f4 = new Fraction();
        Fraction f5 = new Fraction();
        Fraction f6 = new Fraction();
        Fraction f7 = new Fraction();
        Fraction f8 = new Fraction();

        Console.WriteLine(f1.GetFraction());
        Console.WriteLine(f2.GetFraction());
        Console.WriteLine(f3.GetFraction());

        f1.SetTop(5);
        f1.SetBott(3);

        Console.WriteLine(f4.GetFraction());
        Console.WriteLine(f4.GetDecimalValue());

        f5.SetTop(5);
        Console.WriteLine(f5.GetFraction());
        Console.WriteLine(f5.GetDecimalValue());

        f6.SetTop(3);
        f6.SetBott(4);
        Console.WriteLine(f6.GetFraction());
        Console.WriteLine(f6.GetDecimalValue());

        f7.SetTop(1);
        f7.SetBott(3);
        Console.WriteLine(f7.GetFraction());
        Console.WriteLine(f7.GetDecimalValue());

        Random random= new Random();
        for (int i = 0; i < 20; i++)
        {
            int topValue = random.Next(1, 11);
            int bottomValue = random.Next(1, 11);
            f8.SetTop(topValue);
            f8.SetBott(bottomValue);
            Console.Write($"Fraction {i + 1}: ");
            Console.Write($"string: {f8.GetFraction()}");
            Console.WriteLine($" Number: {f8.GetDecimalValue()}");
        }
    }
}