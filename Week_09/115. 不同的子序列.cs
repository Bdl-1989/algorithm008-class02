//https://leetcode-cn.com/problems/distinct-subsequences/


public class Solution {
    public int NumDistinct(string s, string t) {
        int[,] dp = new int[s.Length + 1, t.Length + 1];
        //初始化，如果S是空串，但是T不是空串，那么出现次数为0
        for (int j = 0; j <= t.Length; j++) {
            dp[0,j] = 0;
        }
        //初始化，如果S不是空串，但是T是空串，出现次数为1
        for (int i = 0; i <= s.Length; i++) {
            dp[i,0] = 1;
        }
        for (int i = 1; i <= s.Length; ++i){
            for (int j = 1; j <= t.Length; ++j){
                if (s[i - 1] == t[j - 1]){
                    dp[i,j] = dp[i - 1,j - 1] + dp[i - 1,j];
                }else {
                    dp[i,j] = dp[i - 1,j];
                }
            }
        }
        return dp[s.Length,t.Length];
    }
}