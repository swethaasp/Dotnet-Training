//program.cs


using System.Security.Principal;

namespace AccountsDemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int ch;
            Account a = null;  //a hold the account object.

            do
            {
                Console.WriteLine("*********************************");
                Console.WriteLine("**** Accounts Application *****");
                Console.WriteLine("*********************************");
                Console.WriteLine("1. Create Account");
                Console.WriteLine("2. Display Account Information");
                Console.WriteLine("3. Deposit Amount");
                Console.WriteLine("4. Withdraw Amount");
                Console.WriteLine("0. Quit");
                Console.WriteLine("Enter Choice:");

                ch = int.Parse(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter Account Id:");
                        int Id = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter Name:");
                        string Name = Console.ReadLine();

                        Console.WriteLine("Enter Opening Balance:");
                        decimal Balance = decimal.Parse(Console.ReadLine());

                        a = new Account();
                        a.CreateAccount(Id, Name, Balance);

                        break;

                    case 2:
                        if (a != null)
                            a.DisplayInfo();
                        else
                            Console.WriteLine("********* Open Account First *********\n");
                        break;

                    case 3:
                        if (a != null)
                        {
                            Console.WriteLine("Enter Amount to Deposit:");
                            decimal depositAmount = decimal.Parse(Console.ReadLine());
                            a.Deposit(depositAmount);
                        }
                        else
                            Console.WriteLine("********* Open Account First *********\n");
                        break;

                    case 4:
                        if (a != null)
                        {
                            Console.WriteLine("Enter Amount to Withdraw:");
                            decimal withdrawAmount = decimal.Parse(Console.ReadLine());
                            a.Withdraw(withdrawAmount);
                        }
                        else
                            Console.WriteLine("********* Open Account First *********\n");
                        break;

                    case 0:
                        break;  //come out of the do loop

                    default:
                        Console.WriteLine("*********** Wrong Choice ***********\n");
                        break;
                }
            } while (ch != 0);

            Console.WriteLine("Thanks for Using Banking Operations");
        }
    }
}



//Account.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsDemoApp
{
    public class Account
    {
        public int Id { get; private set; }  //The private keyword before set means that the property can only be modified (set) from within the class itself

        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length >= 15)
                    _name = value;
                else
                    Console.WriteLine("Error: Name should be at least 15 characters long.");
            }
        }

        private decimal _balance;

        public decimal Balance
        {
            get { return _balance; }
            private set { _balance = value; }
        }

        public void CreateAccount(int id, string name, decimal balance)
        {
            Id = id;
            Name = name;
            Balance = balance;
            Console.WriteLine("Account created successfully!\n");
        }

        public void DisplayInfo()
        {
            Console.WriteLine("***** Account Information *****");
            Console.WriteLine("Account Id: " + Id);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Balance: " + Balance);
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine("Amount deposited successfully!\n");
        }

        public void Withdraw(decimal amount)
        {
            if (Balance - amount < 500)
            {
                Console.WriteLine("Insufficient Balance! Minimum balance of 500 must be maintained.\n");
            }
            else
            {
                Balance -= amount;
                Console.WriteLine("Amount withdrawn successfully!\n");
            }
        }
    }
}
