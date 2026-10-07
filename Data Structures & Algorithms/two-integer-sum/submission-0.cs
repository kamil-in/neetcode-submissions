public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var numSet = new HashSet<int>();
		
        for(int i=0;i<nums.Length;i++){
            if(numSet.Contains(target-nums[i])){
                return [Array.IndexOf(nums, target-nums[i]),i];
            } else {
				numSet.Add(nums[i]);
			}
        }
        return [0,0];
    }
}
