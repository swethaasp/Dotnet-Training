You are given a string s. You need to reverse the string.

Example 1:

Input:
s = Geeks
Output: skeeG
Example 2:

Input:
s = for
Output: rof
Your Task:

You only need to complete the function reverseWord() that takes s as parameter and returns the reversed string.

Expected Time Complexity: O(|S|).
Expected Auxiliary Space: O(1).

Constraints:
1 <= |s| <= 10000



class Solution
{
    //Complete this function
    //Function to reverse words in a given string.
    public string reverseWord(string str)
    {
        //Your code here
        /*
        StringBuilder sb =new StringBuilder(str.Length);
        for(int i=str.Length-1;i>=0;i--){
            sb.Append(str[i]);
        }
        return sb.ToString();
        */
        
        char[] c = str.ToCharArray();
        Array.Reverse(c);
        // string s =new string(c);
        // return s;
        
        string s =string.Join("",c);
        return s;
    }
}
