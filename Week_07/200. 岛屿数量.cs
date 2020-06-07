//https://leetcode-cn.com/problems/number-of-islands/

public class Solution {
    private int r;
    private int c;
    public int NumIslands(char[][] grid) {
        if(grid == null) return 0;
        r = grid.Length;
        if(grid.Length == 0) return 0;
        c = grid[0].Length;
        int count = 0;
        for (int i = 0; i < r; ++i){
            for (int j = 0; j < c; ++j){
                if(grid[i][j] == '1'){
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



//

public class Solution {
    int rows;
    int cols;
    public int NumIslands(char[][] grid) {

        rows = grid.Length;
        if (rows == 0) return 0;
        cols = grid[0].Length;
        int dummyNode = cols * rows;
        UnionFind uf = new UnionFind(dummyNode + 1);
        for (int row = 0; row < rows; ++row){
            for (int col = 0; col < cols; ++col){
                if (grid[row][col] == '0') uf.Union(getIndex(row, col), dummyNode);
                else if (grid[row][col] == '1'){
                    if (row < grid.Length - 1 && grid[row][col] == grid[row + 1][col]){
                        uf.Union(getIndex(row, col), getIndex(row + 1, col));
                    } 
                    if (col < grid[0].Length - 1 && grid[row][col] == grid[row][col + 1]){
                        uf.Union(getIndex(row, col), getIndex(row, col + 1));
                    } 
                }

            }
        }
        return uf.count - 1;
    }

    public int getIndex(int x, int y) => x * cols + y;

    public class UnionFind{
        public int count;
        private int[] parent;
        public UnionFind(int n){
            count = n;
            parent = new int[n];
            for (int i = 0; i < n; ++i){
                parent[i] = i;
            }
        }
        public int Find(int p){
            while (p != parent[p]){
                parent[p] = parent[parent[p]];
                p = parent[p];
            }
            return p;
        }
        public void Union(int p, int q){
            int rootP = Find(p);
            int rootQ = Find(q);
            if (rootP == rootQ) return;
            parent[rootP] = rootQ;
            count--;
        }
    }
}