public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> collection = new HashSet<int>();
        foreach(int num in nums){
            if(collection.Contains(num))
                return true;
            else
                collection.Add(num);
        }
        return false;
    }
}