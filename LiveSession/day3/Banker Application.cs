using System;
using System.Collections.Generic;

public class Locker
{
    // Private member fields
    private int number;
    private string lockType;
    private string password;
    private double amount;
    private DateTime lastOpened;

    // Properties to access private fields
    public int Number { get => number; set => number = value; }
    public string LockType { get => lockType; set => lockType = value; }
    public string Password { get => password; set => password = value; }
    public double Amount { get => amount; set => amount = value; }
    public DateTime LastOpened { get => lastOpened; set => lastOpened = value; }

    // Default constructor
    public Locker() { }

    // Parameterized constructor
    public Locker(int number, string lockType, string password, double amount, DateTime lastOpened)
    {
        this.number = number;
        this.lockType = lockType;
        this.password = password;
        this.amount = amount;
        this.lastOpened = lastOpened;
    }

    // Static method to create a Locker object from comma-separated details
    public static Locker CreateLocker(string detail)
    {
        string[] details = detail.Split(',');
        int number = int.Parse(details[0].Trim());
        string lockType = details[1].Trim();
        string password = details[2].Trim();
        double amount = double.Parse(details[3].Trim());
        DateTime lastOpened = DateTime.Parse(details[4].Trim());

        return new Locker(number, lockType, password, amount, lastOpened);
    }

    // ToString method to display locker details
    public override string ToString()
    {
        return string.Format("{0,-8} {1,-15} {2,-8} {3,-10:F1} {4}", number, lockType, password, amount, lastOpened.ToString("dd-MM-yyyy"));
    }
}

public class Bank
{
    private string name;
    private List<Locker> lockers;

    // Constructor to initialize bank name and locker list
    public Bank(string name)
    {
        this.name = name;
        this.lockers = new List<Locker>();
    }

    // Method to add a locker to the bank
    public void AddLockerToBank(Locker locker)
    {
        lockers.Add(locker);
        Console.WriteLine("Locker successfully added.");
    }

    // Method to remove a locker from the bank
    public bool RemoveLockerFromBank(int number)
    {
        Locker lockerToRemove = lockers.Find(locker => locker.Number == number);
        if (lockerToRemove != null)
        {
            lockers.Remove(lockerToRemove);
            Console.WriteLine("Locker successfully deleted.");
            return true;
        }
        else
        {
            Console.WriteLine("Locker not found in the bank.");
            return false;
        }
    }

    // Method to display all lockers in the bank
    public void DisplayLockers()
    {
        if (lockers.Count == 0)
        {
            Console.WriteLine("No lockers to show.");
        }
        else
        {
            Console.WriteLine("Lockers in {0}:", name);
            Console.WriteLine("{0,-8} {1,-15} {2,-8} {3,-10} {4}", "Number", "Lock Type", "Password", "Amount", "Last Opened");
            foreach (var locker in lockers)
            {
                Console.WriteLine(locker);
            }
        }
    }
}

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter the name of the Bank:");
        string bankName = Console.ReadLine();
        Bank bank = new Bank(bankName);

        while (true)
        {
            Console.WriteLine("\n1. Add Locker\n2. Delete Locker\n3. Display Lockers\n4. Exit");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter Locker details (number, lockType, password, amount, lastOpened):");
                    string details = Console.ReadLine();
                    Locker locker = Locker.CreateLocker(details);
                    bank.AddLockerToBank(locker);
                    break;

                case 2:
                    Console.WriteLine("Enter the locker number to be deleted:");
                    int number = int.Parse(Console.ReadLine());
                    bank.RemoveLockerFromBank(number);
                    break;

                case 3:
                    bank.DisplayLockers();
                    break;

                case 4:
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}


//output
Enter the name of the Bank:
sbi

1. Add Locker
2. Delete Locker
3. Display Lockers
4. Exit
Enter your choice: 1
Enter Locker details (number, lockType, password, amount, lastOpened):
123,keypad,435,1000,23-08-2024
Locker successfully added.

1. Add Locker
2. Delete Locker
3. Display Lockers
4. Exit
Enter your choice: 1
Enter Locker details (number, lockType, password, amount, lastOpened):
568,keypad,4689,3000,23-09-2021
Locker successfully added.

1. Add Locker
2. Delete Locker
3. Display Lockers
4. Exit
Enter your choice: 3
Lockers in sbi:
Number   Lock Type       Password Amount     Last Opened
123      keypad          435      1000.0     23-08-2024
568      keypad          4689     3000.0     23-09-2021

1. Add Locker
2. Delete Locker
3. Display Lockers
4. Exit
Enter your choice: 2
Enter the locker number to be deleted:
568
Locker successfully deleted.

1. Add Locker
2. Delete Locker
3. Display Lockers
4. Exit
Enter your choice: 3
Lockers in sbi:
Number   Lock Type       Password Amount     Last Opened
123      keypad          435      1000.0     23-08-2024

1. Add Locker
2. Delete Locker
3. Display Lockers
4. Exit
Enter your choice: 4
