using System;

delegate void AdmissionDelegate();

class Admission
{
    public void VerifyDocuments()
    {
        Console.WriteLine("Documents Verified");
    }

    public void GenerateRollNumber()
    {
        Console.WriteLine("Roll Number Generated");
    }

    public void AllocateDivision()
    {
        Console.WriteLine("Division Allocated");
    }

    public void SendSMS()
    {
        Console.WriteLine("Admission Confirmation SMS Sent");
    }
}

class Program
{
    static void Main()
    {
        Admission a = new Admission();

        AdmissionDelegate d;

        d = a.VerifyDocuments;
        d += a.GenerateRollNumber;
        d += a.AllocateDivision;
        d += a.SendSMS;

        Console.WriteLine("Confirm Admission");
        d();
    }
}
