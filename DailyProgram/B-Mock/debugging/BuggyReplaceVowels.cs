using System;

class Solution
{
    public static string BuggyReplaceVowels(string s)
    {
        char[] result = new char[s.Length];
        for (int i = 0; i < s.Length; i++)
        {
            char ch = s[i];
            char lowerch = char.ToLower(ch); // Error here
            if (lowerch == 'a' || lowerch == 'e' || lowerch == 'i' || lowerch == 'o' || lowerch == 'u')
            {
                if (i > 0 && i < s.Length-1 && !char.IsWhiteSpace(s[i - 1]) && !char.IsWhiteSpace(s[i + 1]) &&
                    !(char.ToLower(s[i - 1]) == 'a' || char.ToLower(s[i - 1]) == 'e' || char.ToLower(s[i - 1]) == 'i' || 
                      char.ToLower(s[i - 1]) == 'o' || char.ToLower(s[i - 1]) == 'u') &&
                    !(char.ToLower(s[i + 1]) == 'a' || char.ToLower(s[i + 1]) == 'e' || char.ToLower(s[i + 1]) == 'i' || 
                      char.ToLower(s[i + 1]) == 'o' || char.ToLower(s[i + 1]) == 'u'))
                {
                    result[i]= '5';   //3==> 5
                }
                else
                {
                    result[i]='3';  //5==>3
                }
            }
            else
            {
                result[i] = ch; 
            }
        }
        return new string(result);
    }

    public static void Main(string[] args)
    {
        string s = Console.ReadLine();
        string result = BuggyReplaceVowels(s);
        Console.WriteLine(result);
    }
}
/*Sample Input
hello
Your Output
h5ll3

*/
