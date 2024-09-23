using System;

class Solution
{
    static string ReplicateVowel(int n, string s)
    {
        string vowels = "aeiouAEIOU"; // Include uppercase vowels if needed
        foreach(char c in s){
           if(vowels.Contains(c)){   //remove ! 
              return new string(c,n);
           } 
        }
        return new string(s[0],n);
        
    }

    static void Main(string[] args)
    {
        int n = Int32.Parse(Console.ReadLine().Trim());
        string s = Console.ReadLine();

        string result = ReplicateVowel(n, s);
        Console.WriteLine(result);
    }
}

//3  argt  op-aaa
