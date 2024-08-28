Given an array arr of size n which contains elements in range from 0 to n-1, you need to find all the elements occurring more than once in the given array. Return the answer in ascending order. If no such element is found, return list containing [-1]. 

Examples:

Input: n = 4, arr[] = [0,3,1,2]
Output: -1
Explanation: There is no repeating element in the array. Therefore output is -1.
Input: n = 5, arr[] = [2,3,1,2,3]
Output: 2 3 
Explanation: 2 and 3 occur more than once in the given array.
Expected Time Complexity: O(n).
Expected Auxiliary Space: O(n).

Constraints:

1 <= n <= 105
0 <= arr[i] <= 105, for each valid i

class Solution {
    // Complete this function
    // Function to find duplicates in an array.
    public List<long> duplicates(long[] arr, int n) {
        // Your code here
        List<long> res=new List<long>();
        Array.Sort(arr);
        for(int i=0;i<n-1;i++){
          if(arr[i]==arr[i+1] ){
              if (res.Count == 0 || res[res.Count - 1] != arr[i]) {
                res.Add(arr[i]);
          }  
        }
        }
        
        if(res.Count==0){
         res.Add(-1);
        
        }
        
        return res;
        
    }
}



//alt


using System;
using System.Collections.Generic;

class Solution {
    // Function to find duplicates in an array.
    public List<int> Duplicates(int[] arr, int n) {
        // Initialize sets to track elements and duplicates
        HashSet<int> seen = new HashSet<int>();
        HashSet<int> duplicates = new HashSet<int>();
        
        // Iterate over the array to find duplicates
        foreach (int num in arr) {
            if (seen.Contains(num)) {
                duplicates.Add(num);
            } else {
                seen.Add(num);
            }
        }
        
        // Convert the HashSet to a List and sort it
        List<int> result = new List<int>(duplicates);
        result.Sort();
        
        // Return the result or [-1] if no duplicates are found
        if (result.Count > 0) {
            return result;
        } else {
            return new List<int> { -1 };
        }
    }
}
