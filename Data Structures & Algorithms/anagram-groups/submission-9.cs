public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var result = new List<List<string>>();
        var keyMaps = new Dictionary<string,List<string>>();
        foreach(string s in strs){
            var lettersKey = new int[26];
            foreach(char c in s){
                lettersKey[(c & 0b11111)-1]=lettersKey[(c & 0b11111)-1]+1;
            } 
            var finalKey = string.Join(",",lettersKey);
            if(!keyMaps.ContainsKey(finalKey)){
                keyMaps.Add(finalKey,new List<string>()); 
            } 
            keyMaps[finalKey].Add(s);
        }
        foreach(var item in keyMaps.Keys){
            var sublist = new List<string>();
            foreach(var s in keyMaps[item]){
                sublist.Add(s);
            }
            result.Add(sublist);
        }

        return result;
    }
}
