using System;
delegate void Operation(int a, int b);
class Calculator
{
    public void Add(int a, int b)
    {
        Console.WriteLine("Addition = " + (a + b));
    }
    public void Subtract(int a, int b)
    {
        Console.WriteLine("Subtraction = " + (a - b));
    }
    public void Multiply(int a, int b)
    {
        Console.WriteLine("Multiplication = " + (a * b));
    }
    public void Divide(int a, int b)
    {
        if (b != 0)
            Console.WriteLine("Division = " + (a / b));
        else
            Console.WriteLine("Cannot divide by zero");

    }
}
class Program
{
    static void Main(string[] args)
    {
        Calculator c = new Calculator();
        Operation obj;
        obj = c.Add;
        obj(20, 10);

        obj = c.Subtract;
        obj(20, 10);

        obj = c.Multiply;
        obj(20, 10);

        obj = c.Divide;
        obj(20, 10);

        Console.WriteLine("Saqlain Khan T013");
        Console.ReadLine();
    }
}
