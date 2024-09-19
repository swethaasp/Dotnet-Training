Given an array nums of size n, return the majority element.

The majority element is the element that appears more than ⌊n / 2⌋ times. You may assume that the majority element always exists in the array.

 

Example 1:

Input: nums = [3,2,3]
Output: 3
Example 2:

Input: nums = [2,2,1,1,1,2,2]
Output: 2
 

Constraints:

n == nums.length
1 <= n <= 5 * 104
-109 <= nums[i] <= 109


  public class Solution {
    public int MajorityElement(int[] nums) {
       
        Dictionary<int,int> dt =new Dictionary<int,int>();
        foreach(int num in nums){
            if(dt.ContainsKey(num)){
                dt[num]++;
            }
            else{
                dt[num]=1;
            }
        }
        
      // foreach(var num in dt){
      //     if(num.Value>nums.Length/2){
      //         return num.Key;
      //     }
      // }
        
       foreach(int val in dt.Values){
           if(val>nums.Length/2){
               foreach(var v in dt){
                   if(val==v.Value){
                       return v.Key;
                   }
               }
           }
       }
        return -1;
    }
}
