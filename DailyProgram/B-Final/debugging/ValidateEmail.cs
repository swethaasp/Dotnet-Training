using System;
using System.Text.RegularExpressions;

public class Program 
{ 
    // Function to validate email addresses
    static bool ValidateEmail(string email) 
    { 
        // Updated pattern to handle valid email formats
        string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"; 
        Regex regex = new Regex(pattern);  // Creates a new Regex object using the provided pattern
        return regex.IsMatch(email); // Checks if the email matches the pattern and returns true or false
    } 

    public static void Main(string[] args) 
    { 
        // Test emails to validate
        string[] emails = { 
            "test@example.com",         // Valid email
            "invalid.email",            // Invalid (no @ symbol)
            "another@test.domain.org",  // Valid (multiple subdomains)
            "noatsign.com"              // Invalid (no @ symbol)
        }; 

        // Iterate through each email and print the validation result
        foreach (var email in emails)
        { 
            Console.WriteLine($"{email}: {ValidateEmail(email)}"); // Output each email with its validation status
        } 
    
