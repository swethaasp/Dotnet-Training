using System;

// Define the Exercise5 class
public class Exercise5
{  
    // Main method - entry point of the program
    public static void Main() 
    {
        string str; // Declare a string variable
        int l, wrd; // Declare variables for string traversal and word count

        // Prompt the user to count the total number of words in a string
        Console.Write("\n\nCount the total number of words in a string:\n");
        Console.Write("------------------------------------------------------\n");
        Console.Write("Input the string: ");
        str = Console.ReadLine(); // Read the user input string

        l = 0; // Initialize a variable for string traversal
        wrd = 1; // Initialize word count assuming at least one word exists

        /* Loop till the end of the string */
        while (l <= str.Length - 1)
        {
            /* Check whether the current character is whitespace, newline, or tab character */
            if (str[l] == ' ' || str[l] == '\n' || str[l] == '\t')
            {
                wrd++; // Increment word count if whitespace, newline, or tab character is found
            }

            l++; // Move to the next character in the string
        }

        // Display the total number of words in the string
        Console.Write("Total number of words in the string is: {0}\n", wrd);
    }
}
