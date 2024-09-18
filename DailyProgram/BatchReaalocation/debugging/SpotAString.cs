using System;
using System.Collections.Generic;

public class Solution
{
    public static int SpotAString(int N, List<string> B)
    {
        int count=0;
        for(int i=0;i<N;i++){
            char ch=B[i][0];
            if(ch=='a' || ch=='A'){
                count++;
            }
        }
        return count;
    }

    public static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine().Trim('0'));
        List<string> B = new List<string>(N);

        for (int j = 0; j < N; j++)
        {
            B.Add(Console.ReadLine());
        }

        int result = SpotAString(N, B);
        Console.WriteLine(result);
    }
}
