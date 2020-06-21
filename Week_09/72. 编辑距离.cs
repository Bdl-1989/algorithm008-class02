//https://leetcode-cn.com/problems/edit-distance/



public class Solution {
    public int MinDistance(string word1, string word2) {
        int n1 = word1.Length;
        int n2 = word2.Length;
        //create 2D array
        int[][] dp = new int[n1 + 1][];
        for (int i = 0; i < n1 + 1; ++i) dp[i] = new int[n2 + 1];
        //initial the boundary
        for (int i = 0; i < n1 + 1; ++i) dp[i][0] = i;
        for (int j = 0; j < n2 + 1; ++j) dp[0][j] = j;
        //status transfer equation/Divide and conquer
        for (int i = 1; i < n1 + 1; ++i){
            for (int j = 1; j < n2 + 1; ++j){
                if (word2[j - 1] == word1[i - 1]) dp[i][j] = dp[i - 1][j - 1];
                else dp[i][j] = Math.Min(dp[i - 1][j - 1] + 1,
                                        Math.Min(dp[i][j - 1] + 1
                                        ,dp[i - 1][j] + 1));
            }
        }
        return dp[n1][n2];
    }
}