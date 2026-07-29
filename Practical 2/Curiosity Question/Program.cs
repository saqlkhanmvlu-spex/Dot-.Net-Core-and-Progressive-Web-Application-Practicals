using System;

class Student
{
    public string Name, Category;
    public int Subjects;

    public Student(string name, string category, int subjects)
    {
        Name = name;
        Category = category;
        Subjects = subjects;
    }

    public virtual int CalculateFee()
    {
        return Subjects * 500;
    }

    public void HallTicket()
    {
        Console.WriteLine("Hall Ticket Generated for " + Name);
    }

    public void PublishResult()
    {
        Console.WriteLine("Result Published for " + Name);
    }

    public void Notify()
    {
        Console.WriteLine("Notification Sent to " + Name);
    }
}

class Regular : Student
{
    public Regular(string n, int s) : base(n, "Regular", s) { }

    public override int CalculateFee()
    {
        return Subjects * 500;
    }
}

class ATKT : Student
{
    public ATKT(string n, int s) : base(n, "ATKT", s) { }

    public override int CalculateFee()
    {
        return Subjects * 700;
    }
}

class Repeater : Student
{
    public Repeater(string n, int s) : base(n, "Repeater", s) { }

    public override int CalculateFee()
    {
        return Subjects * 1000;
    }
}

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Category (Regular/ATKT/Repeater): ");
            string cat = Console.ReadLine();

            Console.Write("Enter Number of Subjects: ");
            int sub = Convert.ToInt32(Console.ReadLine());

            Student s;

            if (cat == "Regular")
                s = new Regular(name, sub);
            else if (cat == "ATKT")
                s = new ATKT(name, sub);
            else if (cat == "Repeater")
                s = new Repeater(name, sub);
            else
                throw new Exception("Invalid Registration Details!");

            Console.WriteLine("Exam Fee: " + s.CalculateFee());

            s.HallTicket();
            s.PublishResult();
            s.Notify();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
