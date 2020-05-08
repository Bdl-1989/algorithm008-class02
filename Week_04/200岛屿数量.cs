//https://leetcode-cn.com/problems/number-of-islands/



//DFS
public class Solution {
    private int r;
    private int c;
    public int NumIslands(char[][] grid) {
        if (grid == null || grid.Length == 0) return 0;
        int count = 0;
        r = grid.Length;
        c = grid[0].Length;
        for (int i = 0; i < r; ++i ){
            for (int j = 0; j < c; ++j){
                if (grid[i][j] == '1'){
                    ++count;
                    dfs(grid, i, j);
                }
            }
        }
        return count;
    }
    internal void dfs(char[][] grid, int i, int j){
        if (i < 0 || j < 0 || i >= r || j >= c || grid[i][j] != '1') return;
        grid[i][j] = '0';
        dfs(grid, i - 1, j);
        dfs(grid, i + 1, j);
        dfs(grid, i, j - 1);
        dfs(grid, i, j + 1);
    }
}