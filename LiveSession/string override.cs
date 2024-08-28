public class Emp
{
    public int Id { get; set; }
    public string EmpName { get; set; }
    public decimal EmpSalary { get; set; }
 
    
    public Emp()
    {
 
    }
    public Emp(int id, string name)
    {
        Id = id;
        EmpName = name;
        EmpSalary = 5000;
    }
    public Emp(int id, string name, decimal salary)
    {
        Id = id;
        EmpName = name;
        EmpSalary = salary;
    }
 
 
    public void Display()
    {
        Console.WriteLine("Employee Id: {0}", Id);
        Console.WriteLine("EmployeeName: {0}", EmpName);
        Console.WriteLine("Salary : {0}", EmpSalary);
    }
 
 
    public override string ToString()
    {
        string s = "Emp Id " + Id;
        s += ", Emp Name: " + EmpName;
        s += "\nEmp Salary: " + EmpSalary;
        return s;
    }
 
}
