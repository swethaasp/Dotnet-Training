public class Solution {
    public bool IsPalindrome(string s) {
       
      string first=s.ToLower();
      string str=new string(first.Where(c=>char.IsLetterOrDigit(c)).ToArray());
      char[] rev=str.ToCharArray();
      Array.Reverse(rev);
      string res=new string(rev);
       return res==str;
    }
}
