using System;

delegate void ResultDelegate();

class Student
{
    int[] marks = new int[5];
    int total;
    double percentage;

    public Student()
    {
        Console.WriteLine("Enter Marks of 5 Subjects:");
        for (int i = 0; i < 5; i++)
            marks[i] = Convert.ToInt32(Console.ReadLine());
    }

    public void TotalMarks()
    {
        total = 0;
        foreach (int m in marks)
            total += m;
        Console.WriteLine("Total Marks = " + total);
    }

    public void Percentage()
    {
        percentage = total / 5.0;
        Console.WriteLine("Percentage = " + percentage);
    }

    public void Grade()
    {
        if (percentage >= 75)
            Console.WriteLine("Grade = A");
        else if (percentage >= 60)
            Console.WriteLine("Grade = B");
        else if (percentage >= 50)
            Console.WriteLine("Grade = C");
        else
            Console.WriteLine("Grade = Fail");
    }

    public void PassFail()
    {
        if (percentage >= 40)
            Console.WriteLine("Result = Pass");
        else
            Console.WriteLine("Result = Fail");
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student();

        ResultDelegate d;

        d = s.TotalMarks;
        d();

        d = s.Percentage;
        d();

        d = s.Grade;
        d();

        d = s.PassFail;
        d();
    }
}
