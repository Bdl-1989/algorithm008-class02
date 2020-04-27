
//https://leetcode-cn.com/problems/get-kth-magic-number-lcci/submissions/

public class Solution {
    public int GetKthMagicNumber(int k) {
        int[] dp = new int[k];
        int p3 = 0, p5 = 0, p7 = 0;
        dp[0] = 1;
        for (int i = 1; i < k; ++i){
            dp[i] = Math.Min(Math.Min(dp[p3] * 3, dp[p5] * 5), dp[p7] * 7);
            if (dp[i] == dp[p3] * 3) ++p3;
            if (dp[i] == dp[p5] * 5) ++p5;
            if (dp[i] == dp[p7] * 7) ++p7;
        }
        return dp[k-1];
    }
}