using System;
public class BankAccount
{
    private string incubent;
    public double Balance;
    private string currency;

    public string Incubent
    {
        get { return incubent; }
        set { incubent = value; }
    }

    public string Currency
    {
       get { return currency; }
        set { currency = value; }

    }



    public BankAccount(string incubent, double balance,string currency)
    {
        Incubent = incubent; 
        Balance = balance;
        Currency = currency;

    }

    public static void Main()
    {
        BankAccount RakiaAccount = new BankAccount("Rakia",500,"Dollar");


       // how tyo use accesor:
       string IncubentAccount= RakiaAccount.incubent;

        Console.WriteLine(RakiaAccount.Balance + " " + RakiaAccount.currency);


    }







}