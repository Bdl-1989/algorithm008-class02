//https://leetcode-cn.com/problems/valid-anagram/

public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;
        int[] bucket = new int[26];
        for (int i = 0; i < s.Length; ++i){
            bucket[s[i] - 'a']++;
            bucket[t[i] - 'a']--;
        }
        for (int i = 0; i < 26; ++i){
            if (bucket[i] != 0) return false;
        }
        return true;
    }
}