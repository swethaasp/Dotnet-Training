1. Write a class Employee and in main use Arraylist of Employee objects.
Display list
also
Sort list on the basis of Salary and display sorted records.
(Hint Use IComparable)
 
using System;
using System.Collections;

public class Employee : IComparable
{
    public string EmpName { get; set; }
    public double Salary { get; set; }

    public Employee(string empName, double salary)
    {
        EmpName = empName;
        Salary = salary;
    }

    public int CompareTo(object obj)
    {
        Employee other = obj as Employee;
       // return EmpName.CompareTo(other.EmpName);
        return Salary.CompareTo(other.Salary);
    }

    public override string ToString()
    {
        return $"{EmpName} with {Salary} salary";
    }
}

class Program
{
    static void Main()
    {
        ArrayList employees = new ArrayList();

        
        employees.Add(new Employee("Alice", 50000));
        employees.Add(new Employee("Bob", 70000));
        employees.Add(new Employee("Charlie", 60000));

       
        Console.WriteLine("Original Employee List:");
        foreach (Employee emp in employees)
        {
            Console.WriteLine(emp);
        }

        
        employees.Sort();

        Console.WriteLine("\nSorted Employee List by Salary:");
        foreach (Employee emp in employees)
        {
            Console.WriteLine(emp);
        }
    }
}
