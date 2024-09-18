using System;

public class Solution
{
    public static int CountNonOverlappingSubstringOccurrences(string str, string t)
    {
        if(string.IsNullOrEmpty(t)){
            return 0;
        }
        
        int start=0;
        int count=0;
        while((start=str.IndexOf(t,start))!=-1){
            count++;
            start=start+t.Length;
        }
        return count;
    }

    public static void Main(string[] args)
    {
        // Read the main string and the substring from input
        string str = Console.ReadLine();
        string t = Console.ReadLine();
        
        // Get the result by calling the method and print it
        int result = CountNonOverlappingSubstringOccurrences(str, t);
        Console.WriteLine(result);
    }
}
