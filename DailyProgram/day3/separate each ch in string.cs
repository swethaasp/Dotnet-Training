using System;
public class Exercise1
{
    public static void Main( )
    {
        string str=Console.ReadLine();
         int l=0;
         while(l<=str.Length-1){
             Console.WriteLine(str[l]);
             l++;
         }
    }
}
