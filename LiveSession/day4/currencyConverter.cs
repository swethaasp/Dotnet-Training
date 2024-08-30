
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
using System.Collections.Generic;

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
        double dollars = NumberOfNotes + NumberOfCoins * 0.01;
        return dollars * PoundToDollarRate * DollarToRupeesRate;
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
    private List<Currency> currencies = new List<Currency>();

    public void AddCurrency(Currency currency)
    {
        currencies.Add(currency);
    }

    public void DisplayTotalInRupees()
    {
        double totalAmount = 0;
        foreach (var currency in currencies)
        {
            totalAmount += currency.ConvertToRupees();
        }
        Console.WriteLine($"Total amount in Rupees: {totalAmount}");
    }
}

// Example usage
public class Program
{
    public static void Main(string[] args)
    {
        // Create some currencies
        Dollar dollar = new Dollar(10, 50); // 10 dollars and 50 cents
        Pound pound = new Pound(5, 25); // 5 pounds and 25 pence
        Rupee rupee = new Rupee(100, 75); // 100 rupees and 75 paise

        // Create a collection box
        CollectionBox box = new CollectionBox();

        // Add currencies to the collection box
        box.AddCurrency(dollar);
        box.AddCurrency(pound);
        box.AddCurrency(rupee);

        // Display total amount in Rupees
        box.DisplayTotalInRupees();
    }
}
