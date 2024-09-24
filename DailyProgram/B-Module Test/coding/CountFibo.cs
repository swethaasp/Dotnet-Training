using System;
using System.Collections.Generic;

using System;
using System.Collections.Generic;

class Solution
{
    static bool IsFibonacci(int num)
    {
        // Check if a number is in the Fibonacci sequence
        int a = 0, b = 1;
        if (num == a || num == b)
            return true;

        int c = a + b;
        while (c <= num)
        {
            if (c == num)
                return true;
            a = b;
            b = c;
            c = a + b;
        }
        return false;
    }

    static int count(int X, int Y)
    {
        HashSet<int> fibonacciNumbers = new HashSet<int>();

        for (int A = 0; A < X; A++)
        {
            for (int B = 0; B < Y; B++)
            {
                int result = (int)Math.Pow(A, B);
                if (IsFibonacci(result))
                {
                    fibonacciNumbers.Add(result);
                }
            }
        }

        return fibonacciNumbers.Count;
    }

    static void Main(string[] args)
    {
        int X = Convert.ToInt32(Console.ReadLine());
        int Y = Convert.ToInt32(Console.ReadLine());

        int result = count(X, Y);
        Console.Write(result);
    }






//alt 
class Solution
{
    static HashSet<int> OgF(int limit){
        HashSet<int> fiboseries=new HashSet<int>();
        
        int a=0;
        int b=1;
        fiboseries.Add(a);
        fiboseries.Add(b);
        while(b<=limit){
            int c=a+b;
            fiboseries.Add(c);  //original fibo series upto 4
            a=b;
            b=c;
        }
        return fiboseries;
    }
    
    static int Count(int X,int Y){
        int maxLimit=(int)Math.Pow(X,Y);
        HashSet<int> orginalFibo = OgF(maxLimit); 

        
        HashSet<int> qnFibo=new HashSet<int>();
        for(int i=0;i<=X;i++){
            for(int j=0;j<=Y;j++){
                int res=(int)Math.Pow(i,j);
                
                if(orginalFibo.Contains(res)){
                qnFibo.Add(res);
                }
            }
            
        }
        return qnFibo.Count;
        
    }

    

    static void Main(string[] args)
    {
        // Input values for X and Y
        int X = Convert.ToInt32(Console.ReadLine());
        int Y = Convert.ToInt32(Console.ReadLine());

        // Get the count of valid combinations
        int result = Count(X, Y);

        // Print the result
        Console.WriteLine(result);
    }
}
