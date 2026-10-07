public class Solution {
    public int[] TwoSum(int[] nums, int target) {	
        var numsMap = new Dictionary<int, int>();
		
        for(int i=0;i<nums.Length;i++){
            if(numsMap.ContainsKey(target-nums[i])){
                return [numsMap[target-nums[i]],i];
            } else {
				numsMap.Add(nums[i],i);
			}
        }
        return [0,0];
    }
}
