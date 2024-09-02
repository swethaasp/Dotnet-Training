Consider a base class  PurchaseItem which models customer’s purchases. This class has:
two private instance variables name (String) and unitPrice (double).
One constructor to initialize the instance variables.
A default constructor to initialize name to “no item”, and unitPrice to 0. use this()
A method getPrice that returns the unitPrice.
A toString method to return the name of the item followed by @ symbol, then the unitPrice.
Consider two derive classes WeighedItem and CountedItem. WeighedItem has an additional instance variable weight (double) in Kg while CountedItem has an additional variable quantity (int) both private.
- Write an appropriate constructor for each of the classes making use of the constructor of the base class in defining those of the derive classes.
- Override getPrice method that returns the price of the purchasedItem based on its unit price and weight (WeighedItem), or quantity (CountedItem).  Make use of getPrice of the base class
- Override also toString method for each class making use of the toString method of the base class in defining those of the derive classes.
toString should return something that can be printed on the receipt.
For example   
Banana @ 3.00   1.37Kg   4.11 SR (in case of WeighedItem class)
Pens @ 4.5      10 units   45 SR (in case of CountedItem class)
Write an application class where you construct objects from the two derive classes and print them on the screen.



using System;

class PurchaseItem
{
    // Private fields
    private string name;
    private double unitPrice;

    // Property for name
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    // Property for unitPrice
    public double UnitPrice
    {
        get { return unitPrice; }
        set { unitPrice = value; }
    }

    // Constructor to initialize name and unitPrice
    public PurchaseItem(string name, double unitPrice)
    {
        this.name = name;
        this.unitPrice = unitPrice;
    }

    // Default constructor
    public PurchaseItem() : this("no item", 0) { }

    // Method to get the unit price
    public virtual double GetPrice()
    {
        return unitPrice;
    }

    // Override ToString method to return name and unitPrice
    public override string ToString()
    {
        return $"{name} @ {unitPrice}";
    }
}

class WeighedItem : PurchaseItem
{
    // Private field for weight
    private double weight;

    // Property for weight
    public double Weight
    {
        get { return weight; }
        set { weight = value; }
    }

    // Constructor using base class constructor and additional weight parameter
    public WeighedItem(string name, double unitPrice, double weight)
        : base(name, unitPrice)
    {
        this.weight = weight;
    }

    // Override GetPrice to return price based on weight
    public override double GetPrice()
    {
        return weight * base.GetPrice();
    }

    // Override ToString to return name, unitPrice, weight, and total price
    public override string ToString()
    {
        return $"{base.ToString()}   {weight}Kg   {GetPrice()} SR";
    }
}

class CountedItem : PurchaseItem
{
    // Private field for quantity
    private int quantity;

    // Property for quantity
    public int Quantity
    {
        get { return quantity; }
        set { quantity = value; }
    }

    // Constructor using base class constructor and additional quantity parameter
    public CountedItem(string name, double unitPrice, int quantity)
        : base(name, unitPrice)
    {
        this.quantity = quantity;
    }

    // Override GetPrice to return price based on quantity
    public override double GetPrice()
    {
        return quantity * base.GetPrice();
    }

    // Override ToString to return name, unitPrice, quantity, and total price
    public override string ToString()
    {
        return $"{base.ToString()}   {quantity} units   {GetPrice()} SR";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Input for WeighedItem
        Console.Write("Enter the name of the weighed item: ");
        string weighedItemName = Console.ReadLine();

        Console.Write("Enter the unit price of the weighed item: ");
        double weighedItemPrice = double.Parse(Console.ReadLine());

        Console.Write("Enter the weight of the weighed item (in Kg): ");
        double weighedItemWeight = double.Parse(Console.ReadLine());

        WeighedItem weighedItem = new WeighedItem(weighedItemName, weighedItemPrice, weighedItemWeight);

        // Input for CountedItem
        Console.Write("Enter the name of the counted item: ");
        string countedItemName = Console.ReadLine();

        Console.Write("Enter the unit price of the counted item: ");
        double countedItemPrice = double.Parse(Console.ReadLine());

        Console.Write("Enter the quantity of the counted item: ");
        int countedItemQuantity = int.Parse(Console.ReadLine());

        CountedItem countedItem = new CountedItem(countedItemName, countedItemPrice, countedItemQuantity);

        // Display the details of the items
        Console.WriteLine("\nWeighed Item Details:");
        Console.WriteLine(weighedItem.ToString());

        Console.WriteLine("\nCounted Item Details:");
        Console.WriteLine(countedItem.ToString());
    }
}
