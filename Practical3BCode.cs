using System;
delegate void Message();
class Program
{
    public void Hello()
    {
        Console.WriteLine("Hello guys!!");
    }
    public void Fine()
    {
        Console.WriteLine("How are you all?? I'm fine.");
    }
    static void Main(string[] args)
    {
        Program p = new Program();
        Message msg = p.Hello;
        msg += p.Fine;
        msg();
        Console.WriteLine("Saqlain Khan T013");
        Console.ReadLine();
    }
}
