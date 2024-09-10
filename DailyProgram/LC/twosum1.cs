public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        
        Dictionary<int,int> dict =new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++){
            int comple= target-nums[i];
            if(dict.ContainsKey(comple)){
                return new int[]{dict[comple],i};
            }
            else{
                dict[nums[i]]=i;
            }
        }
        return new int[]{0,0};
    }
}
