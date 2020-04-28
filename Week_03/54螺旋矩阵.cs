//https://leetcode-cn.com/problems/spiral-matrix/


public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) {
        if (matrix.Length == 0) return new List<int>();
        int top = 0;
        int left = 0;
        int bottom = matrix.Length - 1;
        int right = matrix[0].Length - 1;

        IList<int> list = new List<int>();
        int direction = 0;
        while (right >= left && bottom >= top) {
            if (direction == 0){
                for (int i = left; i <= right; ++i) list.Add(matrix[top][i]);
                ++top;
            }else if (direction == 1){
                for (int i = top; i <= bottom; ++i) list.Add(matrix[i][right]);
                --right;
            }else if (direction == 2){
                for (int i = right; i >= left; --i) list.Add(matrix[bottom][i]);
                --bottom;
            }else if (direction == 3){
                for (int i = bottom; i >= top; --i) list.Add(matrix[i][left]);
                ++left;
            }
            direction = (direction + 1) % 4;
        }
        return list;
    }
}

