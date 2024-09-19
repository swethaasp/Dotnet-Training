using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public static string max_number(string A, string L)
    {
       Dictionary<char,int> dt =new Dictionary<char,int>();
       foreach(char n in L){
           if(dt.ContainsKey(n)){
               dt[n]=dt[n]+1;
           }
           else{
               dt[n]=1;
           }
       }
       
       List<char> lt =new List<char>();
       foreach(char i in A){
         if(dt.ContainsKey(i)){
             dt[i]--;
         } 
         else{
            lt.Add(i); 
         }
       }
       
       string fl =new string(lt.ToArray());
       return fl;
       
      
    }

    public static void Main()
    {
        // Example input
        string A = "123456789";
        string L = "35";
        
        // Call the function and print the result
        Console.WriteLine(max_number(A, L));  // Output: "1246789"
    }
}


//using hashset
using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public static string max_number(string A, string L)
    {
       HashSet<char> ht =new HashSet<char>();
       foreach(char c in L){
           ht.Add(c);
       }
       
       List<char> lt =new List<char>();
       foreach(char c1 in A){
           if(!ht.Contains(c1)){
            lt.Add(c1);   
           }
       }
       
      string s =new string(lt.ToArray());
      return s;
    }

    public static void Main()
    {
        // Example input
        string A = "123456789";
        string L = "35";
        
        // Call the function and print the result
        Console.WriteLine(max_number(A, L));  // Output: "1246789"
    }
}
