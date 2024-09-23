using System;

public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        int n = s.Length;
        int maxLen = 0;
        int l = 0;
        int r = 0;
        int[] hash = new int[256];

        // Initialize the hash array with -1
        Array.Fill(hash, -1);

        while (r < n)
        {
            // If the character is already seen
            if (hash[s[r]] != -1)
            {
                // Move left pointer to the right of the last occurrence
                if (hash[s[r]] >= l)
                {
                    l = hash[s[r]] + 1;
                }
            }

            // Update the maximum length
            int len = r - l + 1;
            maxLen = Math.Max(len, maxLen);

            // Update the last seen index of the character
            hash[s[r]] = r;
            r++;
        }

        return maxLen;
    }
}

// Example usage
public class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        string input = "abcabcbb"; // Example input
        int result = solution.LengthOfLongestSubstring(input);
        Console.WriteLine($"Length of longest substring without repeating characters: {result}");
    }
}

/*
xplanation of the Code:
Initialization:

maxLen: To store the maximum length found.
l and r: Two pointers for the sliding window.
hash: An array of size 256 to track the last occurrence of each character (assuming extended ASCII).
Loop:

While r is less than the length of the string:
Check if the character at position r has been seen before.
If it has been seen and is within the current window (i.e., hash[s[r]] >= l), move the left pointer l to the right of the last occurrence.
Calculate the length of the current substring and update maxLen if it's greater than the previous maximum.
Update the last seen index of the current character.
Move the right pointer r forward.
Return: Finally, return the maximum length found.

This C# code mirrors the logic of your original Java code closely and should work efficiently for the problem of finding the longest substring without repeating characters.






You said:
Input: s = "pwwkew"
Output: 3
Explanation: The answer is "wke", with the length of 3.
Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.step by step expalin
ChatGPT said:
ChatGPT
Let's break down how the algorithm works step by step for the input string s = "pwwkew" to find the length of the longest substring without repeating characters. The expected output is 3, corresponding to the substring "wke".

Step-by-Step Explanation:
Initialization:

Input: s = "pwwkew"
Variables:
n = 6 (length of the string)
maxLen = 0 (to keep track of the maximum length of substring found)
l = 0 (left pointer for the sliding window)
r = 0 (right pointer for the sliding window)
hash = new int[256] (to track the last index of each character, initialized to -1)
Iterating Through the String:

While loop runs as long as r < n.
First Iteration (r = 0):

Character: s[0] = 'p'
hash['p'] is -1 (not seen before).
Update hash['p'] to 0 (current index).
Length of current substring: len = r - l + 1 = 0 - 0 + 1 = 1.
Update maxLen = max(0, 1) = 1.
Second Iteration (r = 1):

Character: s[1] = 'w'
hash['w'] is -1 (not seen before).
Update hash['w'] to 1.
Length of current substring: len = 1 - 0 + 1 = 2.
Update maxLen = max(1, 2) = 2.
Third Iteration (r = 2):

Character: s[2] = 'w'
hash['w'] is 1 (last seen at index 1).
Since hash['w'] >= l, move l to hash['w'] + 1 = 2.
Update hash['w'] to 2.
Length of current substring: len = 2 - 2 + 1 = 1.
maxLen remains 2.
Fourth Iteration (r = 3):

Character: s[3] = 'k'
hash['k'] is -1 (not seen before).
Update hash['k'] to 3.
Length of current substring: len = 3 - 2 + 1 = 2.
maxLen remains 2.
Fifth Iteration (r = 4):

Character: s[4] = 'e'
hash['e'] is -1 (not seen before).
Update hash['e'] to 4.
Length of current substring: len = 4 - 2 + 1 = 3.
Update maxLen = max(2, 3) = 3.
Sixth Iteration (r = 5):

Character: s[5] = 'w'
hash['w'] is 2 (last seen at index 2).
Since hash['w'] >= l, move l to hash['w'] + 1 = 3.
Update hash['w'] to 5.
Length of current substring: len = 5 - 3 + 1 = 3.
maxLen remains 3.
Conclusion:
The loop ends when r reaches the length of the string.
The maximum length of a substring without repeating characters is 3, corresponding to the substring "wke".
