Given a string S, check if it is palindrome or not.

Example 1:

Input: S = "abba"
Output: 1
Explanation: S is a palindrome
Example 2:

Input: S = "abc" 
Output: 0
Explanation: S is not a palindrome
Your Task:
You don't need to read input or print anything. Complete the function isPalindrome()which accepts string S and returns an integer value 1 or 0.

Expected Time Complexity: O(Length of S)
Expected Auxiliary Space: O(1)

Constraints:
1 <= Length of S<= 2*105

class Solution{
	
    //Complete this function
	public bool isPalindrome(string S){
        //Your code here
        int start=0;
        int end =S.Length-1;
        
        while(start<end){
            if(S[start]!=S[end]){
                return false;
            }
            start++;
            end--;
        }
        return true;
    }
}
