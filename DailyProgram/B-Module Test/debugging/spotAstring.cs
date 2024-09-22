using System;
using System.Collections.Generic;

class Solution
{
    public static int spotAstring(int N, List<string> B)
    {
        int ans = 0; // Initialize answer to 0

        // Iterate through the string array
        for (int i = 0; i < N; i++)
        {
            // Check if the string is not empty before accessing the first character
            if (!string.IsNullOrEmpty(B[i]))
            {
                char ch = B[i][0]; // Get the first character

                // Check if the first character is 'a' or 'A'
                if (ch == 'a' || ch == 'A')
                {
                    ans += 1; // Increment the count
                }
            }
        }
        return ans; // Return the final count
    }

    static void Main(string[] args)
    {
        int N = Int32.Parse(Console.ReadLine().Trim());
        List<string> B = new List<string>();

        for (int i = 0; i < N; i++)
        {
            B.Add(Console.ReadLine().Trim()); // Read each string and add to the list
        }

        int result = spotAstring(N, B);
        Console.WriteLine(result); // Print the result
    }
}
