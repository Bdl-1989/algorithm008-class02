//https://leetcode-cn.com/problems/minimum-path-sum/

public class Solution {
    public int MinPathSum(int[][] grid) {
        int[][] dp = new int[grid.Length][];
        for (int i = 0; i < grid.Length; ++i) dp[i] = new int[grid[0].Length];
        for (int i = 0; i < grid.Length; ++i){
            for (int j = 0; j < grid[0].Length; ++j){
                if (i == 0 && j ==0){
                     dp[0][0] = grid[0][0];
                     continue;
                }
                if (i == 0){
                    dp[i][j] = grid[i][j] + dp[i][j - 1];
                }else if (j == 0){
                    dp[i][j]  = grid[i][j] + dp[i - 1][j];
                }else {
                    dp[i][j]  = grid[i][j] + Math.Min(dp[i][j - 1], dp[i - 1][j]);
                }
 
            }
        }
        return dp[grid.Length - 1][grid[0].Length -1] ;
    }
}