using System;
class Flyod
{
    static void Main()
    {
        string[] city = new string[10];

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Enter city " + (i + 1) + ": ");
            city[i] = Console.ReadLine();
        }
        Array.Sort(city);
        Console.WriteLine("\n----- Sorted Cities -----");
        for (int i = 0; i < city.Length; i++)
        {
            Console.WriteLine(city[i]);
        }
        Console.WriteLine("Saqlain Khan T013");
    }
}
