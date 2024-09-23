public class Solution {
    public int SingleNumber(int[] nums) {
        
        Dictionary<int,int> dt =new Dictionary<int,int>();
        foreach(int num in nums){
            if(dt.ContainsKey(num)){
                dt[num]++;
            }
            else{
                dt[num]=1;
            }
        }
        
        foreach(var n in dt){
            if(n.Value==1){
               return n.Key; 
            }
        }
        return -1;
    }
}
