using System;
using System.Collections.Generic;

// Define the Person class that implements IComparable<Person>
public class Person : IComparable<Person>
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Implement the CompareTo method to compare persons by Age
    public int CompareTo(Person other)
    {
        if (other == null) return 1;

        // Natural ordering by Age in ascending order
        return this.Age.CompareTo(other.Age);
    }

    // Override ToString method for better output representation
    public override string ToString()
    {
        return $"{Name} ({Age} years old)";
    }
}

class Program
{
    static void Main()
    {
        // Create a list of Person objects
        List<Person> people = new List<Person>
        {
            new Person("Alice", 30),
            new Person("Bob", 25),
            new Person("Charlie", 35)
        };

        Console.WriteLine("Original List:");
        foreach (Person person in people)
        {
            Console.WriteLine(person);
        }

        // Sort the list of Person objects
        people.Sort();  // This calls the CompareTo method in Person class

        Console.WriteLine("\nSorted List by Age (Ascending):");
        foreach (Person person in people)
        {
            Console.WriteLine(person);
        }
    }
}
