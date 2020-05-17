//https://leetcode-cn.com/problems/search-a-2d-matrix/

public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0) return false;
        int r = matrix.Length;
        int c = matrix[0].Length;
        int left = 0, right = r * c - 1;
        while (left <= right){
            int mid = (left + right) / 2;
            if (matrix[mid / c][mid % c] == target) return true;
            if (matrix[mid / c][mid % c] < target) left = mid + 1;
            else if (matrix[mid / c][mid % c] > target) right = mid - 1;
        }
        return false;
    }
}