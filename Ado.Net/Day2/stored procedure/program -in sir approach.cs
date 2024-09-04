using System;
using System.Data;
using System.Data.SqlClient;

namespace AdoNetDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Call to insert a new employee
            InsertEmpSP();

            // Call to show all employees
            ShowAllEmpsSP();
        }

        // Method to insert a new employee using a stored procedure
        public static void InsertEmpSP()
        {
            SqlConnection con = new SqlConnection(Helper.ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "InsertEmp";
            cmd.CommandType = CommandType.StoredProcedure;

            // Define parameters for the stored procedure
            SqlParameter parName = new SqlParameter("@EmpName", SqlDbType.NVarChar, 50);
            SqlParameter parSalary = new SqlParameter("@EmpSalary", SqlDbType.Decimal);
            SqlParameter parId = new SqlParameter("@EmpId", SqlDbType.Int);
            parId.Direction = ParameterDirection.Output;

            // Get user input for employee name and salary
            Console.Write("Enter Employee Name: ");
            parName.Value = Console.ReadLine();
            Console.Write("Enter Employee Salary: ");
            parSalary.Value = decimal.Parse(Console.ReadLine());

            // Add parameters to the command
            cmd.Parameters.Add(parName);
            cmd.Parameters.Add(parSalary);
            cmd.Parameters.Add(parId);

            // Execute the stored procedure
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            // Display the newly generated employee ID
            Console.WriteLine($"New Employee Inserted with ID: {parId.Value}");
        }

        // Method to show all employees using a stored procedure
        public static void ShowAllEmpsSP()
        {
            SqlConnection con = new SqlConnection(Helper.ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "ShowAllEmps";
            cmd.CommandType = CommandType.StoredProcedure;

            // Open connection and execute the stored procedure
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            // Display employee records
            Console.WriteLine("EmpID\tEmpName\tEmpSalary");
            while (dr.Read())
            {
                Console.WriteLine($"{dr["EmpID"]}\t{dr["EmpName"]}\t{dr["EmpSalary"]}");
            }

            // Close the reader and connection
            dr.Close();
            con.Close();
        }
    }
}
