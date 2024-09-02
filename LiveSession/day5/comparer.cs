namespace Day_6_Comaparer
{
    using System;
    using System.Collections.Generic;

    // Employee class definition
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        // Overriding ToString method to display employee details
        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Salary: {Salary}";
        }
    }

    // Comparer for sorting by Name (ascending) and then by Salary (descending)
    public class NameSalaryComparer : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            // First, compare names in ascending order
            int nameComparison = x.Name.CompareTo(y.Name);

            if (nameComparison == 0)
            {
                // If names are the same, compare salaries in descending order
                return y.Salary.CompareTo(x.Salary);
            }

            return nameComparison;  // Return the result of name comparison
        }
    }

    class Program
    {
        static void Main()
        {
            // Creating a list of employees
            List<Employee> employees = new List<Employee>
        {
            new Employee(1, "Alice", 50000),
            new Employee(2, "Bob", 70000),
            new Employee(3, "Alice", 60000),
            new Employee(4, "Charlie", 50000),
            new Employee(5, "Bob", 40000)
        };

            Console.WriteLine("Original Employee List:");
            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp);
            }

            // Sorting using NameSalaryComparer
            employees.Sort(new NameSalaryComparer());

            Console.WriteLine("\nSorted Employee List by Name (Ascending) and then by Salary (Descending):");
            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp);
            }
        }
    }
}

