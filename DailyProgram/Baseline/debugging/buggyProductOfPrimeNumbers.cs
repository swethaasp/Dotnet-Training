using System;
using System.Collections.Generic;

public class Solution
{
    public static bool isPrime(int num){
        if(num<=1){
            return false;
        }
        
        for(int i=2;i<num;i++){
            if(num%i==0){
                return false;
            }
        }
        return true;
    }
   

    public static int buggyProductOfPrimeNumbers(int n,List<int> arr){
        int product=1;
        const int mod = 1000000007;
        
        foreach(int num in arr){
            if(isPrime(num)){
                product=product*num %mod;
            }
        }
        return product;
    }

    public static void Main(string[] args)
    {
        // Input the size of the array
        int n = int.Parse(Console.ReadLine().Trim());
        List<int> arr = new List<int>(n);

        // Input the array elements
        for (int i = 0; i < n; i++)
        {
            arr.Add(int.Parse(Console.ReadLine().Trim()));
        }

        // Calculate and print the product of prime numbers
        int result = buggyProductOfPrimeNumbers(n, arr);
        Console.WriteLine(result);
    }
}
