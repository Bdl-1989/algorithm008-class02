学习笔记

##String
- java/python/c# 's string is immutable.


- 总结状态方程
```
public class Solution {
    public int UniquePathsWithObstacles(int[][] obstacleGrid) {
        int row = obstacleGrid.Length;
        int col = obstacleGrid[0].Length;
        int[,] dp = new int[row + 1, col + 1];
        for (int i = row - 1; i >= 0; --i){
            for (int j = col - 1; j >= 0; --j){
                if (i == row - 1 && j == col - 1) {
                    if(obstacleGrid[i][j] == 1) dp[i,j] = 0;
                    else dp[i,j] = 1;
                    continue;
                }
                if (obstacleGrid[i][j] == 1){
                    dp[i,j] = 0;
                }else{
                    dp[i,j] = dp[i + 1,j] + dp[i,j + 1];                    
                }
            }
        }
        return dp[0,0];
    }
}

```