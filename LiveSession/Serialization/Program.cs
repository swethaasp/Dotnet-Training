using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json; //  JSON serialization
using System.Xml.Serialization; //  XML serialization;

class Program
{
    static void Main()
    {
        
        List<Employee> employees = new List<Employee>
        {
            new Employee(1, "John Doe", 50000, new DateTime(2018, 1, 15)),
            new Employee(2, "Jane Smith", 60000, new DateTime(2019, 3, 22)),
            new Employee(3, "Jim Brown", 55000, new DateTime(2020, 6, 10))
        };

        // Serialize to JSON and write to EMP.JSON
        SerializeToJson(employees, "EMP.JSON");

        // Serialize to XML and write to EMP.XML
        SerializeToXml(employees, "EMP.XML");

        // Deserialize from JSON and display
        List<Employee> deserializedEmployees = DeserializeFromJson("EMP.JSON");
        Console.WriteLine("Deserialized Employees from EMP.JSON:");
        foreach (var emp in deserializedEmployees)
        {
            Console.WriteLine(emp);
        }


        // Deserialize from XML and display
        List<Employee> deserializedEmployeesXml = DeserializeFromXml("EMP.XML");
        Console.WriteLine("\nDeserialized Employees from EMP.XML:");
        foreach (var emp in deserializedEmployeesXml)
        {
            Console.WriteLine(emp);
        }
    }

  
    static void SerializeToJson(List<Employee> employees, string fileName)
    {
        string jsonString = JsonSerializer.Serialize(employees, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(fileName, jsonString);
        Console.WriteLine($"Employees serialized to {fileName}.");
    }

   
    static void SerializeToXml(List<Employee> employees, string fileName)
    {
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Employee>));
        using (TextWriter writer = new StreamWriter(fileName))
        {
            xmlSerializer.Serialize(writer, employees);
        }
        Console.WriteLine($"Employees serialized to {fileName}.");
    }

    // Method to deserialize from JSON file
    static List<Employee> DeserializeFromJson(string fileName)
    {
        string jsonString = File.ReadAllText(fileName);
        return JsonSerializer.Deserialize<List<Employee>>(jsonString);
    }

    // Method to deserialize from XML file
    static List<Employee> DeserializeFromXml(string fileName)
    {
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Employee>));
        using (FileStream fileStream = new FileStream(fileName, FileMode.Open))
        {
            return (List<Employee>)xmlSerializer.Deserialize(fileStream);
        }
    }
}
