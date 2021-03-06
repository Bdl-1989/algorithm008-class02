//https://leetcode-cn.com/problems/longest-valid-parentheses/

public class Solution {
    public int LongestValidParentheses(string s) {
        int maxlen = 0;
        int[] dp = new int[s.Length];
        for (int i = 1; i < s.Length; ++i){
            if (s[i] == ')'){
                if (s[i - 1] == '('){
                    dp[i] = (i - 2 >= 0 ? dp[i - 2] : 0) + 2;
                }else if (i - dp[i - 1] - 1 >= 0 && s[i - dp[i - 1] - 1] == '('){
                    dp[i] = (i - dp[i - 1] - 2 >= 0 ? dp[i - dp[i - 1] - 2] : 0) + dp[i - 1] + 2;
                }
            }
            maxlen = Math.Max(maxlen, dp[i]);
        }
        return maxlen;
    }
}