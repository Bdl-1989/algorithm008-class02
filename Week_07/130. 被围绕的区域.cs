//https://leetcode-cn.com/problems/surrounded-regions/

public class Solution {
    int rows;
    int cols;
    public void Solve(char[][] board) {
        rows = board.Length;
        if (rows == 0) return;
        cols = board[0].Length;
        int dummy = rows * cols;
        UnionFind uf = new UnionFind(dummy + 1);
        for (int i = 0; i < rows; ++i){
            for (int j = 0; j < cols; ++j){
                if (board[i][j] == 'O'){
                    if (i == 0 || j == 0 || i == rows -1 || j == cols - 1){
                        uf.Union(GetIndex(i, j), dummy);
                    }else{
                        if (i > 0 && board[i - 1][j] == 'O'){
                            uf.Union(GetIndex(i, j), GetIndex(i - 1, j));
                        }
                        if (j > 0 && board[i][j - 1] == 'O'){
                            uf.Union(GetIndex(i, j), GetIndex(i, j - 1));
                        }
                        if (i < rows - 1 && board[i + 1][j] == 'O'){
                            uf.Union(GetIndex(i, j), GetIndex(i + 1, j));
                        }
                        if (j < cols - 1 && board[i][j + 1] == 'O'){
                            uf.Union(GetIndex(i, j), GetIndex(i, j + 1));
                        }
                    } 
                }
            }
        }
        for (int i = 0; i < rows; ++i){
            for (int j = 0; j < cols; ++j){
                if (!uf.isConnected(GetIndex(i, j), dummy)) board[i][j] = 'X';
            }
        }
        
    }
    public int GetIndex(int x, int y) => x * cols + y;
}
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
        while ( p != parent[p]){
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
    public bool isConnected(int p, int q){
        return Find(p) == Find(q);
    }
}

