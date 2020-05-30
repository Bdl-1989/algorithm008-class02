//https://leetcode-cn.com/problems/maximal-square/


public class Solution {
    public int MaximalSquare(char[][] matrix) {
        if (matrix.Length == 0) return 0;
        int res = 0;
        int[][] map = new int[matrix.Length + 1][];
        for (int i = 0; i < matrix.Length + 1; ++i) map[i] = new int[matrix[0].Length + 1];
        for (int i = matrix.Length - 1; i >= 0; --i){
            for (int j = matrix[0].Length - 1; j >= 0; --j){
                if (matrix[i][j] == '1') map[i][j] = 1;
            }
        }
        for (int i = matrix.Length - 1; i >= 0; --i){
            for (int j = matrix[0].Length - 1; j >= 0; --j){
                if (map[i][j] == 1 ){
                    map[i][j] = Math.Min(map[i][j + 1], Math.Min(map[i + 1][j + 1],map[i + 1][j])) + 1;
                    res = Math.Max(res, map[i][j]);
                }
            }
        }
        return res*res;
    }
}