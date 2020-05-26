//https://leetcode-cn.com/problems/valid-palindrome-ii/

public class Solution {
    public bool ValidPalindrome(string s) {
        return helper(0, s.Length - 1, 1, s);
    }
    internal bool helper(int i, int j, int n, string s){
        if (i > j) return true;
        if (s[i] == s[j]) return helper(i + 1, j - 1, n, s);
        else if (n == 0) return false;
        else return helper(i + 1, j, n - 1, s) || helper(i, j - 1, n -1, s);
    }
}