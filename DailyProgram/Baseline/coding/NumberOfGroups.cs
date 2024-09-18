using System;
using System.Collections.Generic;

public class Solution
{
    public static int NumberOfGroups(int N, string f)
    {
        const int MOD=1000000007;
        Dictionary<char,int> dt =new Dictionary<char,int>();
        foreach(char c in f){
            if(dt.ContainsKey(c)){
                dt[c]=dt[c]+1;
            }
            else{
                dt[c]=1;
            }
        }
        
        int totgrp=0;
        foreach(int cnt in dt.Values){
            if(cnt>=2){
                totgrp+=cnt*(cnt-1)/2;
                totgrp%=MOD;
            }
        }
        return totgrp;
    }

    public static void Main()
    {
        Console.WriteLine(NumberOfGroups(6, "aabbcc")); // Example usage
    }
}
