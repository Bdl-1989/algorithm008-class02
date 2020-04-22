//1. t is longer


//2. 暴力



// https://leetcode-cn.com/problems/is-subsequence/submissions/

//应该还有其他解法

//practice day: 4-21；4-22

public class Solution {
    public bool IsSubsequence(string s, string t) {
        if (s.Length == 0) return true;
        char[] c = t.ToCharArray();
        int i = 0;
        foreach(char item in c){
            if(item == s[i]){
                if(i == s.Length - 1) return true;
                ++i;
            }
        }
        return false;
    }
}