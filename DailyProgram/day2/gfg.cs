Indexes of Subarray Sum
Difficulty: MediumAccuracy: 16.5%Submissions: 1.6MPoints: 4
Given an unsorted array arr of size n that contains only non negative integers, find a sub-array (continuous elements) that has sum equal to s. You mainly need to return the left and right indexes(1-based indexing) of that subarray.

In case of multiple subarrays, return the subarray indexes which come first on moving from left to right. If no such subarray exists return an array consisting of element -1.

Examples:

Input: arr[] = [1,2,3,7,5], n = 5, s = 12
Output: 2 4
Explanation: The sum of elements from 2nd to 4th position is 12.
Input: arr[] = [1,2,3,4,5,6,7,8,9,10], n = 10, s = 15,
Output: 1 5
Explanation: The sum of elements from 1st to 5th position is 15.
Input: arr[] = [7,2,1], n = 3, s = 2
Output: 2 2
Explanation: The sum of elements from 2nd to 2nd position is 2.
Input: arr[] = [5,3,4], n = 3, s = 2
Output: -1
Explanation: There is no subarray with sum 2
Expected Time Complexity: O(n)
Expected Auxiliary Space: O(1)

Constraints:

0 <= arr[i] <= 109
1 <= n <= 105
0 <= s <= 109



  public class Solution {
    // Complete this function
    // Function to find a continuous sub-array which adds up to a given number.
    public List<int> subarraySum(List<int> arr, int n, long s) {
        // Your code here
        List<int> list =new List<int>();
        for(int i=0;i<arr.Count;i++){
            int sum =0;
            for(int j=i;j<arr.Count;j++){
              sum=sum+arr[j];
              if(sum==s){
                list.Add(i+1);
                list.Add(j+1); 
                return list;
              }
             
            }
        }
        list.Add(-1);
        return list;
    }
}


//alt sliding window
public class Solution {
    // Complete this function
    // Function to find a continuous sub-array which adds up to a given number.
    public List<int> subarraySum(List<int> arr, int n, long s) {
        // Your code here
        List<int> list =new List<int>();
        
        if(n==0 || s<0){
            list.Add(-1);
            return list;
        }
        
        
        int start=0;
        int currsum=0;
        
        for(int end=0;end<n;end++){
            currsum= currsum + arr[end];
            
            while(currsum>s && start<end){
                currsum= currsum -arr[start];
                start++;
            }
            
            if(currsum==s){
                list.Add(start+1);
                list.Add(end+1);
                return list;
            }
        }
        list.Add(-1);
        return list;
    }
}
