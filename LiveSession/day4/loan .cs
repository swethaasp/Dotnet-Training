Write a class that represent the loan in a bank. It has principal amount, number of periods, and an interest rate. 
Interest rate remains constant throughout the payment period.  Bank can issue several types of loans. 
Derive two classes for Serial Loan and Annuity Loans. The application should implement all classes and print a plan for the loan's amortization, which is a status of loan. You must be able to find out:
The nth payment
Repayment at the nth payment
Interest at nth payment
Outstanding after the nth payment.


  using System;

abstract class Loan
{
    // Properties
    public double PrincipalAmount { get; set; }
    public int NumberOfPeriods { get; set; }
    public double InterestRate { get; set; } // Annual interest rate in percentage

    // Constructor
    protected Loan(double principalAmount, int numberOfPeriods, double interestRate)
    {
        PrincipalAmount = principalAmount;
        NumberOfPeriods = numberOfPeriods;
        InterestRate = interestRate;
    }

    // Abstract method to calculate monthly payment
    public abstract double CalculateMonthlyPayment();

    // Method to print amortization schedule
    public void PrintAmortizationSchedule()
    {
        Console.WriteLine("Amortization Schedule:");
        Console.WriteLine("Period\tPayment\t\tPrincipal\tInterest\tBalance");

        double balance = PrincipalAmount;
        double monthlyPayment = CalculateMonthlyPayment();
        double monthlyInterestRate = InterestRate / 12 / 100;

        for (int period = 1; period <= NumberOfPeriods; period++)
        {
            double interestPayment = balance * monthlyInterestRate;
            double principalPayment = monthlyPayment - interestPayment;
            balance -= principalPayment;

            if (balance < 0) balance = 0; // Avoid negative balance

            Console.WriteLine($"{period}\t{monthlyPayment:F2}\t\t{principalPayment:F2}\t\t{interestPayment:F2}\t\t{balance:F2}");
        }
    }
}

class SerialLoan : Loan
{
    // Constructor
    public SerialLoan(double principalAmount, int numberOfPeriods, double interestRate)
        : base(principalAmount, numberOfPeriods, interestRate) { }

    // Override method to calculate monthly payment
    public override double CalculateMonthlyPayment()
    {
        double monthlyInterestRate = InterestRate / 12 / 100;
        double totalPayment = 0;

        for (int period = 1; period <= NumberOfPeriods; period++)
        {
            double currentPrincipal = PrincipalAmount / NumberOfPeriods;
            double interestPayment = (PrincipalAmount - (currentPrincipal * (period - 1))) * monthlyInterestRate;
            totalPayment += currentPrincipal + interestPayment;
        }

        return totalPayment / NumberOfPeriods;
    }
}

class AnnuityLoan : Loan
{
    // Constructor
    public AnnuityLoan(double principalAmount, int numberOfPeriods, double interestRate)
        : base(principalAmount, numberOfPeriods, interestRate) { }

    // Override method to calculate monthly payment
    public override double CalculateMonthlyPayment()
    {
        double monthlyInterestRate = InterestRate / 12 / 100;
        double numerator = monthlyInterestRate * Math.Pow(1 + monthlyInterestRate, NumberOfPeriods);
        double denominator = Math.Pow(1 + monthlyInterestRate, NumberOfPeriods) - 1;
        return PrincipalAmount * (numerator / denominator);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Input for Serial Loan
        Console.Write("Enter the principal amount for Serial Loan: ");
        double serialLoanPrincipal = double.Parse(Console.ReadLine());

        Console.Write("Enter the number of periods (months) for Serial Loan: ");
        int serialLoanPeriods = int.Parse(Console.ReadLine());

        Console.Write("Enter the annual interest rate (in percentage) for Serial Loan: ");
        double serialLoanInterestRate = double.Parse(Console.ReadLine());

        SerialLoan serialLoan = new SerialLoan(serialLoanPrincipal, serialLoanPeriods, serialLoanInterestRate);

        // Input for Annuity Loan
        Console.Write("Enter the principal amount for Annuity Loan: ");
        double annuityLoanPrincipal = double.Parse(Console.ReadLine());

        Console.Write("Enter the number of periods (months) for Annuity Loan: ");
        int annuityLoanPeriods = int.Parse(Console.ReadLine());

        Console.Write("Enter the annual interest rate (in percentage) for Annuity Loan: ");
        double annuityLoanInterestRate = double.Parse(Console.ReadLine());

        AnnuityLoan annuityLoan = new AnnuityLoan(annuityLoanPrincipal, annuityLoanPeriods, annuityLoanInterestRate);

        // Print amortization schedules
        Console.WriteLine("\nSerial Loan Amortization Schedule:");
        serialLoan.PrintAmortizationSchedule();

        Console.WriteLine("\nAnnuity Loan Amortization Schedule:");
        annuityLoan.PrintAmortizationSchedule();
    }
}

  
