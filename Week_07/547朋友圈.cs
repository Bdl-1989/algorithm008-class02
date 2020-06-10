//https://leetcode-cn.com/problems/friend-circles/


public class Solution {
    public int FindCircleNum(int[][] M) {
        int[] visited = new int[M.Length];
        int count = 0;
        for (int i = 0; i < M.Length; ++i){
            if (visited[i] == 0){
                dfs(M, visited, i);
                count++;
            }
        }
        return count;
    }
    private void dfs(int[][] M, int[] visited, int i){
        for (int j = 0; j < M.Length; ++j){
            if (M[i][j] == 1 && visited[j] == 0){
                visited[j] = 1;
                dfs(M, visited, j);
            }
        }
    }
}


// 并查集
public class Solution {
    public int FindCircleNum(int[][] M) {
        UnionFind uf = new UnionFind(M.Length);
        for (int col = 0; col < M[0].Length; ++col){
            for (int row = col; row < M.Length; ++row){
                if (M[row][col] == 1) uf.Union(row, col);
            }
        }
        return uf.count;
    }

    public class UnionFind{
        public int count;
        private int[] parent;
        private int[] size;
        public UnionFind(int n){
            count = n;
            parent = new int[n];
            size = new int[n];
            for (int i = 0; i < n; ++i){
                parent[i] = i;
                size[i] = 1;
            }
        }
        public int Find (int p){
            while (p != parent[p]) {
                parent[p] = parent[parent[p]];
                p = parent[p];
            }
            return p;
        }
        public void Union(int p, int q){
            int rootP = Find(p);
            int rootQ = Find(q);
            if (rootP == rootQ) return;
            //小树接大树
            if (size[rootP] > size[rootQ]){
                parent[rootQ] = rootP;
                size[rootQ] += size[rootP];
            }else{
                parent[rootP] = rootQ;
                size[rootP] += size[rootQ];
            }
            
            count--;
        }
    }
}