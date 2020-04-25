
//https://leetcode-cn.com/problems/zero-matrix-lcci/


public class Solution {
    public void SetZeroes(int[][] matrix) {
        HashSet<int> rowClean = new HashSet<int>();
        HashSet<int> colClean = new HashSet<int>();
        for (int i = 0; i < matrix.Length; ++i){
            for (int j = 0; j < matrix[0].Length; ++j){
                if (matrix[i][j] == 0){
                    rowClean.Add(i);
                    colClean.Add(j);
                }
            }
        }
        foreach (var i in rowClean){
            for (int j = 0; j < matrix[0].Length; ++j){
                matrix[i][j] = 0;
            }
        }
        foreach (var j in colClean){
            for (int i = 0; i <  matrix.Length; ++i){
                matrix[i][j] = 0;
            }
        }
    }
}