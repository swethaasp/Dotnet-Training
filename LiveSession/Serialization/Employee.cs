using System;
using System.Collections.Generic;

public class Employee
{
    public int ID { get; set; }
    public string EmpName { get; set; }
    public double Salary { get; set; }
    public DateTime DOJ { get; set; }

    public Employee(int id, string empName, double salary, DateTime doj)
    {
        ID = id;
        EmpName = empName;
        Salary = salary;
        DOJ = doj;
    }

    public Employee() { } 

    public override string ToString()
    {
        return $"ID: {ID}, Name: {EmpName}, Salary: {Salary}, DOJ: {DOJ.ToShortDateString()}";
    }
}
