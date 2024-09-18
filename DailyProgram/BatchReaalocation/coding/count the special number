using System;
using System.Collections.Generic;

public class Solution
{
    // Function to calculate the sum of digits until it's a single digit
    public static int singlesum(int num){
        while(num>=10){
         num=reducesum(num);
        }
        return num;
    }
    
    public static int  reducesum(int num){
        int sum=0;
        while(num>0){
            sum=sum+num%10;
            num=num/10;
        }
        return sum;
    }
    
    public static int factorial(int num){
        int factorial=1;
        for(int i=2;i<=num;i++){
            factorial=factorial*i;
        }
        return factorial;
    }
    
    
    public static bool isSpl(int num){
        int finalsum=singlesum(num);
        int finalfactorialsum=factorial(finalsum);
        
        HashSet<char> hs =new HashSet<char>(finalfactorialsum.ToString().ToCharArray());
        
        foreach(char c in num.ToString().ToCharArray()){
            if(!hs.Contains(c)){
                return false;
            }
    
        }
        return true;
    }
    
   public static int FactorialSum (int[] arr){
       int count=0;
       foreach(int num in arr){
           if(isSpl(num)){
               count++;
           }
       }
       return count;
   }

    public static void Main(string[] args)
    {
        int array_length = int.Parse(Console.ReadLine().Trim());

        int[] arr = new int[array_length];
        for (int j = 0; j < array_length; j++)
        {
            arr[j] = int.Parse(Console.ReadLine().Trim());
        }

        int result = FactorialSum(arr);
        Console.WriteLine(result);
    }
}
