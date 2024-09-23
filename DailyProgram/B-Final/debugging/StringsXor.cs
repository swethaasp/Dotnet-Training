using System;

class Program
{
    static string StringsXor(string s, string t)
    {
        // Ensure both strings have the same length
        if (s.Length != t.Length)
        {
            throw new ArgumentException("Input strings must be of the same length.");
        }

        string res = "";
        for (int i = 0; i < s.Length; i++)
        {
            // Use comparison operator '=='
            if (s[i] == t[i])
            {
                res += "0"; // Append '0' if characters are the same
            }
            else
            {
                res += "1"; // Append '1' if characters are different
            }
        }
        return res;
    }

    static void Main(string[] args)
    {
        string s = Console.ReadLine();
        string t = Console.ReadLine();
        try
        {
            Console.WriteLine(StringsXor(s, t));
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
