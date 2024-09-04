using System;
using System.Data;
using System.Data.SqlClient;

namespace AdoNetDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Insert a new employee record
            InsertNewEmp("Varsha", 35000);

            // Show all employee records
            ShowAllEmps();
        }

        // Method to insert a new employee record
        public static void InsertNewEmp(string empName, decimal empSalary)
        {
            using (SqlConnection con = new SqlConnection(Helper.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("InsertEmp", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Define parameters
                    cmd.Parameters.AddWithValue("@EmpName", empName);
                    cmd.Parameters.AddWithValue("@EmpSalary", empSalary);

                    // Output parameter for the newly created employee ID
                    SqlParameter empIdParam = new SqlParameter("@EmpId", SqlDbType.Int);
                    empIdParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(empIdParam);

                    // Open the connection
                    con.Open();

                    // Execute the command
                    cmd.ExecuteNonQuery();

                    // Get the generated EmpId
                    int empId = (int)cmd.Parameters["@EmpId"].Value;
                    Console.WriteLine($"New employee inserted with ID: {empId}");
                }
            }
        }

        // Method to show all employee records
        public static void ShowAllEmps()
        {
            using (SqlConnection con = new SqlConnection(Helper.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("ShowAllEmps", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Open the connection
                    con.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        // Display employee records
                        Console.WriteLine("EmpID\tEmpName\tEmpSalary");
                        while (dr.Read())
                        {
                            Console.WriteLine($"{dr["EmpID"]}\t{dr["EmpName"]}\t{dr["EmpSalary"]}");
                        }
                    }
                }
            }
        }
    }
}
