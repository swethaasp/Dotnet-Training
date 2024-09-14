Given an integer array nums, find the subarray with the largest sum, and return its sum.

 

Example 1:

Input: nums = [-2,1,-3,4,-1,2,1,-5,4]
Output: 6
Explanation: The subarray [4,-1,2,1] has the largest sum 6.
Example 2:

Input: nums = [1]
Output: 1
Explanation: The subarray [1] has the largest sum 1.
Example 3:

Input: nums = [5,4,-1,7,8]
Output: 23
Explanation: The subarray [5,4,-1,7,8] has the largest sum 23.
 

Constraints:

1 <= nums.length <= 105
-104 <= nums[i] <= 104



 //brute force
   public class Solution {
    public int MaxSubArray(int[] nums) {
    
        
        int max=int.MinValue;
       for(int i=0;i<nums.Length;i++){
            for(int j=i;j<nums.Length;j++){
             int sum=0;
             for(int k=i;k<=j;k++){
               sum=sum+nums[j];
            }
            if(sum>max){
              max=sum; 
           }
       }
    }
      return max;
    }
}

//better 
  public class Solution {
    public int MaxSubArray(int[] nums) {
    
        
        int max=int.MinValue;
       for(int i=0;i<nums.Length;i++){
            int sum=0;
           for(int j=i;j<nums.Length;j++){
               sum=sum+nums[j];
                 if(sum>max){
                   max=sum; 
           }
       }
       }
        return max;
    }
}


//best  -omit if sum is less than 0
public class Solution {
    public int MaxSubArray(int[] nums) {
    
        
        int max=int.MinValue;
        int sum=0;
       for(int i=0;i<nums.Length;i++){
          sum=sum+nums[i];
            if(sum>max){
               max=sum;
           }
           
           if(sum<0){
               sum=0;
           }
           
          
       }
        return max;
    }
}

