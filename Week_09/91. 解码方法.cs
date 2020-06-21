//https://leetcode-cn.com/problems/decode-ways/

public class Solution {
    public int NumDecodings(string s) {
        int len = s.Length;
        if (len == 0) return 0;
        int[] dp = new int[len];
        dp[0] = 0;
        if (s[0] == '0') return 0;
        dp[0] = 1;
        for (int i = 1; i < len; ++i){
            if (s[i] != '0') dp[i] = dp[i - 1];
            int num = 10 * (s[i - 1] - '0') + (s[i] - '0');
            if (num >= 10 && num <= 26){
                if (i == 1) dp[i]++;
                else dp[i] += dp[i - 2];
            }
        }
        return dp[len - 1];
    }
}


public class Solution {
    public int NumDecodings(string s) {
        if (s == null || s.Length == 0) return 0;
        int len = s.Length;
        int[] dp = new int[len + 1];
        dp[len] = 1;
        if (s[len - 1] == '0') dp[len - 1] = 0;
        else dp[len - 1] = 1;
        for (int i = len - 2; i >= 0; i--){
            if (s[i] == '0'){
                dp[i] = 0;
                continue;
            }
            if ((s[i] - '0') * 10 + (s[i + 1] - '0') <= 26) dp[i] = dp[i + 1] + dp[i + 2];
            else dp[i] = dp[i + 1];
        }
        return dp[0];
    }
}