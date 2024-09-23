using System;
using System.Collections.Generic;

class Solution
{
    public static int BuggyCountStringsOfTargetLengthAndChar(int n, List<string> arr, int length, char targetChar)
    {
        // Initialize a counter
        int count = 0;

        // Iterate through each string in the list
        for (int i = 0; i < n; i++)
        {
            // Check if the string has the specified length and contains the target character
            if (arr[i].Length == length && arr[i][0]==targetChar)    //arr[i][1] ==> arr[i][0]
            {
                count++;  // Increment the count if the condition is met
            }
        }

        // Return the final count of matching strings
        return count;
    }

    public static void Main(string[] args)
    {
        // Read the number of strings
        int n = Int32.Parse(Console.ReadLine().Trim());

        // Initialize a list to store the strings
        List<string> arr = new List<string>();

        // Read n strings and add them to the list
        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().Trim());
        }

        // Read the target length and target character
        int length = Int32.Parse(Console.ReadLine().Trim());
        char targetChar = Char.Parse(Console.ReadLine().Trim());

        // Call the BuggyCountStringsOfTargetLengthAndChar function
        int result = BuggyCountStringsOfTargetLengthAndChar(n, arr, length, targetChar);

        // Print the result
        Console.WriteLine(result);
    }
}


/*3
cat
dog
cow
3
c

op
2 */
