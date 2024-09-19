using System;
using System.Collections.Generic;
using System.IO;

public class Solution
{
    public static int SumQueries(int Q, List<int> Queries)
    {
        const int Mod = 1000000007;
        long ans = 0;
        
        foreach (int x in Queries)
        {
    
            long z = (long)x * (x+1) / 2;  // Use long to prevent overflow
            z %= Mod;
            ans += z;
            ans %= Mod;  // Ensure ans stays within bounds of mod
        }
         //ans %= Mod;
        
        return (int)ans;
    }
    
    public static void Main()
    {
        using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
        {
            int Q = int.Parse(sr.ReadLine().Trim());
            List<int> Queries = new List<int>();
            
            for (int i = 0; i < Q; i++)
            {
                Queries.Add(int.Parse(sr.ReadLine().Trim()));
            }
            
            Console.WriteLine(SumQueries(Q, Queries));
        }
    }
}//832961424
