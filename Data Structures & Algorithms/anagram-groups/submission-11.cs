public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {

        var keyMaps = new Dictionary<string,List<string>>();

        foreach(string s in strs){
            var lettersKey = new int[26];
            foreach(char c in s){
                lettersKey[(c & 0b11111)-1]++;
            } 
            var finalKey = string.Join(",",lettersKey);
            if(!keyMaps.ContainsKey(finalKey)){
                keyMaps.Add(finalKey,new List<string>()); 
            } 
            keyMaps[finalKey].Add(s);
        }

        return new List<List<string>>(keyMaps.Values);
    }
}
