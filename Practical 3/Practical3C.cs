using System;
class BankAccount
{
    public int AccountNumber { get; set; }
    private double balance;
    public double Balance
    {
        get { return balance; }
        set
        {
            if (value >= 0)
                balance = value;
            else
                Console.WriteLine("Balance cannot be negative.");
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        BankAccount b = new BankAccount();
        b.AccountNumber = 1001;
        b.Balance = 5000;
        Console.WriteLine("Account Number: " + b.AccountNumber);
        Console.WriteLine("Balance: " + b.Balance);
        b.Balance = -2000;
        Console.WriteLine("Final Balance: " + b.Balance);
        Console.WriteLine("Saqlain Khan T013");
        Console.ReadKey();
    }
}
