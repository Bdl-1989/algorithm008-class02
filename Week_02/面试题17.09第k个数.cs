//https://leetcode-cn.com/problems/get-kth-magic-number-lcci/

//1. stack
//2. 丑数？

public class Solution {
    public int GetKthMagicNumber(int k) {
        int[] dp = new int[k];
        dp[0] = 1;
        int p3 = 0, p5 = 0, p7 = 0;
        for (int i = 1; i < k; ++i){
            dp[i] = Math.Min(Math.Min(dp[p3] * 3, dp[p5] * 5), dp[p7] * 7);
            if (dp[i] == dp[p3] * 3) ++p3;
            if (dp[i] == dp[p5] * 5) ++p5;
            if (dp[i] == dp[p7] * 7) ++p7;
        }
        return dp[k-1];
    }
}