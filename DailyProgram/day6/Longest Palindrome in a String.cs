Given a string str, find the longest palindromic substring in str. Substring of string str: str[ i . . . . j ] where 0 ≤ i ≤ j < len(str). Return the longest palindromic substring of str.

Palindrome string: A string that reads the same backward. More formally, str is a palindrome if reverse(str) = str. In case of conflict, return the substring which occurs first ( with the least starting index).

Examples :

Input: str = "aaaabbaa"
Output: aabbaa
Explanation: The longest Palindromic substring is "aabbaa".
Input: str = "abc"
Output: a
Explanation: "a", "b" and "c" are the longest palindromes with same length. The result is the one with the least starting index.
Expected Time Complexity: O(|str|2).
Expected Auxiliary Space: O(1).

Constraints:
1 ≤ |str| ≤ 103



  class Solution
    {
        //Complete this function
        //Function to return a string representing the longest palindrome
        //that can be made by deleting one character from the given string.
        public string longestPalin(string s)
        {
            //Your code here
            int start=0;
            int maxlen=1;
            
            for(int i=0;i<s.Length;i++){
                expandAroundCentre(s,i,i,ref start,ref maxlen); //odd length palindrome
                expandAroundCentre(s,i,i+1,ref start,ref maxlen); //even length palindrome
            }
            return s.Substring(start,maxlen);
        }
        
        public void expandAroundCentre(string s,int left,int right,ref int start,ref int maxlen)
        {
            while(left>=0 && right<s.Length&& s[left]==s[right])
            {
                int currlen=right-left+1;
                if(currlen>maxlen){
                    maxlen=currlen;
                    start=left;
                }
                
                left--;
                right++;
            }
        }
        
        

    }
