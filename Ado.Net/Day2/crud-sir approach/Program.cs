using System;
using System.Data;
using System.Data.SqlClient;

namespace AdoNetDemo
{
    public class Program
    {
        static SqlConnection con = new SqlConnection(Helper.ConnectionString);

        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("Product Management");
                Console.WriteLine("1. Add New Product");
                Console.WriteLine("2. Update Existing Product");
                Console.WriteLine("3. Delete Existing Product");
                Console.WriteLine("4. Get Product Details by ID");
                Console.WriteLine("5. Get All Products from Table");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddNewProduct();
                        break;
                    case 2:
                        UpdateProduct();
                        break;
                    case 3:
                        DeleteProduct();
                        break;
                    case 4:
                        GetProductById();
                        break;
                    case 5:
                        GetAllProducts();
                        break;
                    case 0:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            } while (choice != 0);
        }

        public static void AddNewProduct()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO Products (ProductName, ProductPrice) VALUES ('" + GetInput("Enter Product Name: ") + "', " + decimal.Parse(GetInput("Enter Product Price: ")) + ")";
            cmd.CommandType = CommandType.Text;

            con.Open();
            cmd.ExecuteNonQuery();
            Console.WriteLine("Product added successfully!");
            con.Close();
        }

        public static void UpdateProduct()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE Products SET ProductName = '" + GetInput("Enter New Product Name: ") + "', ProductPrice = " + decimal.Parse(GetInput("Enter New Product Price: ")) + " WHERE ProductId = " + int.Parse(GetInput("Enter Product ID to update: "));
            cmd.CommandType = CommandType.Text;

            con.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            con.Close();

            if (rowsAffected > 0)
                Console.WriteLine("Product updated successfully!");
            else
                Console.WriteLine("No product found with the specified ID.");
        }

        public static void DeleteProduct()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "DELETE FROM Products WHERE ProductId = " + int.Parse(GetInput("Enter Product ID to delete: "));
            cmd.CommandType = CommandType.Text;

            con.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            con.Close();

            if (rowsAffected > 0)
                Console.WriteLine("Product deleted successfully!");
            else
                Console.WriteLine("No product found with the specified ID.");
        }

        public static void GetProductById()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Products WHERE ProductId = " + int.Parse(GetInput("Enter Product ID to view details: "));
            cmd.CommandType = CommandType.Text;

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                Console.WriteLine($"Product ID: {reader["ProductId"]}, Name: {reader["ProductName"]}, Price: {reader["ProductPrice"]}");
            }
            else
            {
                Console.WriteLine("No product found with the specified ID.");
            }
            reader.Close();
            con.Close();
        }

        public static void GetAllProducts()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Products";
            cmd.CommandType = CommandType.Text;

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Console.WriteLine("Product ID\tProduct Name\tProduct Price");
            while (reader.Read())
            {
                Console.WriteLine($"{reader["ProductId"]}\t\t{reader["ProductName"]}\t\t{reader["ProductPrice"]}");
            }
            reader.Close();
            con.Close();
        }

        private static string GetInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }
    }
}
