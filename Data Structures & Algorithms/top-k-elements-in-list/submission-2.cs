public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var result = new int[k];
        var sortedMap = new Dictionary<int,int>();
        foreach(int n in nums){
            if(!sortedMap.ContainsKey(n)){
                sortedMap.Add(n,1);
            }
            sortedMap[n]++;
        }
        return sortedMap
            .OrderByDescending(x=>x.Value)
            .Take(k)
            .Select(x=>x.Key)
            .ToArray();
    }
}
