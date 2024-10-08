Given two strings s and goal, return true if and only if s can become goal after some number of shifts on s.

A shift on s consists of moving the leftmost character of s to the rightmost position.

For example, if s = "abcde", then it will be "bcdea" after one shift.
 

Example 1:

Input: s = "abcde", goal = "cdeab"
Output: true
Example 2:

Input: s = "abcde", goal = "abced"
Output: false
 

Constraints:

1 <= s.length, goal.length <= 100
s and goal consist of lowercase English letters.

 public class Solution {
    public bool RotateString(string s, string goal) {
        
        if(s.Length!=goal.Length){
            return false;
        }
      foreach(var s1 in s){
          s=s.Substring(1)+s[0];
          if(s.Contains(goal)){  //s==goal
              return true;
          }
      }
        return false;
}
}

//i=1  bcdea
//i=2  cdeab
//i=3 deabc
