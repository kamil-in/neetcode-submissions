public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
            return false;

        var charMaps = new Dictionary<char, int>();

        for(int i=0;i<s.Length;i++){
            if(!charMaps.ContainsKey(s[i])) {
                charMaps.Add(s[i],0);
            }
            charMaps[s[i]]++;
                
            if(!charMaps.ContainsKey(t[i])) {
                charMaps.Add(t[i],0);
            }    
            charMaps[t[i]]--; 
        }
              

        if(charMaps.Where(x=>x.Value != 0).Count() == 0)
            return true;
        else
            return false;
    }
}
