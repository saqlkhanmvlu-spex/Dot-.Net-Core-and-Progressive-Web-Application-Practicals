using System;
public class ABC
{
    void Sun1(int num1, int num2)
    {
        Console.WriteLine("Subtraction of Two Numbers : " + (num1 - num2));
    }
    void Sun1(int num, int num1, int num2)
    {
        Console.WriteLine("Addition of 3 Numbers : " + (num + num1 + num2));
    }
    public static void Main(string[] args)
    {
        ABC obj = new ABC();
        obj.Sun1(68, 1);
        obj.Sun1(11, 12, 13);
    }
}
