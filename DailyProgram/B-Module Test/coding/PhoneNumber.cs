using System;
using System.Linq;
class Solution
{
    // Function to extract the last 10 digits from the given string
    static string PhoneNumber(string S)
    {
        string digits="";
        foreach(char c in S){
            if(char.IsDigit(c)){
                digits+=c;
            }
            
        }
        return digits.Substring(digits.Length-10);

      /*string digit=new string(S.Where(char.IsDigit).ToArray());
        return digit.Substring(digit.Length-10);
      */
    }

    static void Main(string[] args)
    {
        string S = Console.ReadLine();
        string result = PhoneNumber(S);
        Console.WriteLine(result);
    }
}

