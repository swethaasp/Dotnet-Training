
The Charity Collection Box contains money in different currencies - dollars-cents or pounds-pence or rupees-paise. 
  All of these currencies have notes and coins. 
  The note and coin numbers are counted when they are added based on their value (that is number of 5 rupee notes, or $1 dollar note). 
  A base class representing Currency is created with different denomination for notes and coins. 
  Subclass Dollar, Pound and Rupee has conversion methods to rupees, print() and compute().
  Create class called CollectionBox that allows entry of these currencies in terms of number of notes and coins of different denomination. 
  Create a display method that allows any of these currency types and displays the total amount collected in terms of Rupees.
(Assume1 dollar= Rs. 60 and 1 pound = 2.65 U.S. dollars)


Solution


using System;

// Base class for Currency
public abstract class Currency
{
    public int NumberOfNotes { get; set; }
    public int NumberOfCoins { get; set; }

    public Currency(int notes, int coins)
    {
        NumberOfNotes = notes;
        NumberOfCoins = coins;
    }

    public abstract double ConvertToRupees();
}

// Dollar subclass
public class Dollar : Currency
{
    private const double DollarToRupeesRate = 60;

    public Dollar(int notes, int coins) : base(notes, coins) { }

    public override double ConvertToRupees()
    {
        return (NumberOfNotes + NumberOfCoins * 0.01) * DollarToRupeesRate;
    }
}

// Pound subclass
public class Pound : Currency
{
    private const double PoundToDollarRate = 2.65;
    private const double DollarToRupeesRate = 60;

    public Pound(int notes, int coins) : base(notes, coins) { }

    public override double ConvertToRupees()
    {
        double dollars = (NumberOfNotes + NumberOfCoins * 0.01) * PoundToDollarRate;
        return dollars * DollarToRupeesRate;
    }
}

// Rupee subclass
public class Rupee : Currency
{
    public Rupee(int notes, int coins) : base(notes, coins) { }

    public override double ConvertToRupees()
    {
        return NumberOfNotes + NumberOfCoins * 0.01;
    }
}

// CollectionBox class
public class CollectionBox
{
    private double totalRupees = 0;

    public void AddCurrency(Currency currency)
    {
        totalRupees += currency.ConvertToRupees();
    }

    public void DisplayTotalInRupees()
    {
        Console.WriteLine($"Total amount in Rupees: {totalRupees}");
    }
}

// Program class
public class Program
{
    public static void Main(string[] args)
    {
        CollectionBox box = new CollectionBox();

        // Input Dollar currency
        Console.WriteLine("Enter number of dollars and cents:");
        int dollarNotes = int.Parse(Console.ReadLine());
        int dollarCoins = int.Parse(Console.ReadLine());
        Dollar dollar = new Dollar(dollarNotes, dollarCoins);
        box.AddCurrency(dollar);

        // Input Pound currency
        Console.WriteLine("Enter number of pounds and pence:");
        int poundNotes = int.Parse(Console.ReadLine());
        int poundCoins = int.Parse(Console.ReadLine());
        Pound pound = new Pound(poundNotes, poundCoins);
        box.AddCurrency(pound);

        // Input Rupee currency
        Console.WriteLine("Enter number of rupees and paise:");
        int rupeeNotes = int.Parse(Console.ReadLine());
        int rupeeCoins = int.Parse(Console.ReadLine());
        Rupee rupee = new Rupee(rupeeNotes, rupeeCoins);
        box.AddCurrency(rupee);

        // Display total amount
        box.DisplayTotalInRupees();
    }
}
