// https://leetcode-cn.com/problems/palindromic-substrings/

baoli

public class Solution {
    int count;
    public int CountSubstrings(string s) {
        count = 0;
        int left = 0, right = 0;
        while (right < s.Length){
            ++right;
            while (left < right){
                int len = right - left;
                if (balance(s.Substring(left, len))) count++;
                ++left;
            }
            left = 0;

        }
        return count;
    }
    private bool balance(string s){
        if (s.Length == 1) return true;
        for(int i = 0; i < s.Length / 2; ++i){
            if (s[i] != s[s.Length - i - 1]) return false;
        }
        return true;
    }
}