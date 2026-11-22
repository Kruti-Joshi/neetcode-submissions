public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char,int> freq = new Dictionary<char,int>();

        foreach(char c in s){
            if(!freq.ContainsKey(c)){
                freq.Add(c, 1);
            }
            else
                freq[c]++;
        }

        foreach(char c in t){
            if(!freq.ContainsKey(c)){
                return false;
            }
            freq[c]--;
        }

        if(freq.Values.Any(c => c != 0)){
            return false;
        }
        else{
            return true;
        }
    }
}
