//1. 暴力，sort，是否相等？O(NlogN)
//2. hash, map -->统计每个字符的频次

// https://leetcode-cn.com/problems/valid-anagram/description/
//practice day: 4-21；4-22, 4-23
public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;
        int[] busket = new int[26];
        for (int i = 0; i < s.Length; ++i){
            ++(busket[s[i]-'a']);
            --(busket[t[i]-'a']);
        }
        for (int i = 0; i < busket.Length; ++i){
            if (busket[i] != 0) return false;
        }
        return true;
    }
}