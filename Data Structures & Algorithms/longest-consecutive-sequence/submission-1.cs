public class Solution {
    public int LongestConsecutive(int[] nums) {
        var numsHash = nums.ToHashSet();
        int maxLength = 0;
        foreach(int n in nums){
            int length = 1;
            if(!numsHash.Contains(n-1)){
                int target = n;
                while(numsHash.Contains(target+1)){
                    target++;
                    length++;
                }
            } 
            if(length > maxLength) { maxLength = length; }
        }
        return maxLength;
    }
}
