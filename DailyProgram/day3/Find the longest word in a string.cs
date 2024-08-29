using System;
public class Exercise1
{
    public static void Main( )
    {
         string str=Console.ReadLine();
         string[] strarr = str.Split(' ');
         string maxStr="";
         foreach(string a in strarr){
             if(a.Length>maxStr.Length){
                 maxStr=a;
             }
         }
         Console.WriteLine(maxStr);
    }
}

// output
This is a wonderful day. i have enjoyed with my friends.
wonderful

=== Code Execution Successful ===
