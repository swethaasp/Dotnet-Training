using System;

public class Solution
{
   public static int domethod(int[] arr){
       int n =arr.Length;
       int sum=0;
       foreach(int val in arr){
           sum+=val;
       }
       return sum*n;
   }

    public static void Main()
    {
      int[]  arr =new int[5];
      for(int i=0;i< arr.Length;i++){
          arr[i]=int.Parse(Console.ReadLine());
      }
      Console.Write(domethod(arr));
    }
}
