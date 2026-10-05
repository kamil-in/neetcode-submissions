public class Solution {
    public bool IsAnagram(string s, string t) {
        char[] sArray = s.ToCharArray();
        char[] tArray = t.ToCharArray();
        Array.Sort(sArray);
        Array.Sort(tArray);
        if(sArray.Length == tArray.Length){
            for(int i=0;i<s.Length;i++){
                if(sArray[i]!=tArray[i])
                    return false;
            }
        } 
        else
            return false;       
        return true;
    }
}
