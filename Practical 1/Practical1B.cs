using System;
class Floyd
{
    static void Main()
    {
        int count = 1;

        for (int i = 0; i <= 5; i++) // rows
        {
            for (int j = 0; j <= i; j++) 
            {
                Console.Write(count + " ");
                count++;
            }
            Console.WriteLine();
        }
        Console.WriteLine("Saqlain Khan T013");
    }
}
