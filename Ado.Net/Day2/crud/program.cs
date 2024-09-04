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
            SqlCommand cmd = new SqlCommand("INSERT INTO Products (ProductName, ProductPrice) VALUES (@Name, @Price)", con);
            cmd.Parameters.AddWithValue("@Name", GetInput("Enter Product Name: "));
            cmd.Parameters.AddWithValue("@Price", decimal.Parse(GetInput("Enter Product Price: ")));

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            Console.WriteLine("Product added successfully!");
        }

        public static void UpdateProduct()
        {
            SqlCommand cmd = new SqlCommand("UPDATE Products SET ProductName = @Name, ProductPrice = @Price WHERE ProductId = @Id", con);
            cmd.Parameters.AddWithValue("@Id", int.Parse(GetInput("Enter Product ID to update: ")));
            cmd.Parameters.AddWithValue("@Name", GetInput("Enter New Product Name: "));
            cmd.Parameters.AddWithValue("@Price", decimal.Parse(GetInput("Enter New Product Price: ")));

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
            SqlCommand cmd = new SqlCommand("DELETE FROM Products WHERE ProductId = @Id", con);
            cmd.Parameters.AddWithValue("@Id", int.Parse(GetInput("Enter Product ID to delete: ")));

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
            SqlCommand cmd = new SqlCommand("SELECT * FROM Products WHERE ProductId = @Id", con);
            cmd.Parameters.AddWithValue("@Id", int.Parse(GetInput("Enter Product ID to view details: ")));

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
            con.Close();
        }

        public static void GetAllProducts()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Products", con);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Console.WriteLine("Product ID\tProduct Name\tProduct Price");
            while (reader.Read())
            {
                Console.WriteLine($"{reader["ProductId"]}\t\t{reader["ProductName"]}\t\t{reader["ProductPrice"]}");
            }
            con.Close();
        }

        private static string GetInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }
    }
}
