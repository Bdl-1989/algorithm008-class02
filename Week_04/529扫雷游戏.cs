//https://leetcode-cn.com/problems/minesweeper/submissions/

//practice day: 5-10

public class Solution {
    public char[][] UpdateBoard(char[][] board, int[] click) {
        if (board[click[0]][click[1]] == 'M') {
            board[click[0]][click[1]] = 'X';
            return board;
        }
        dfs(board, click[0], click[1]);
        return board;
    }
    public void dfs(char[][] board, int i, int j){
        if (i < 0 || i >= board.Length || j < 0 || j >= board[0].Length || board[i][j] != 'E') return;
        int mine = 0;
        int startRow = i - 1 < 0? 0 : i - 1;
        int endRow = i + 1 >= board.Length ? board.Length - 1: i + 1;
        int startCol = j - 1 < 0 ? 0 : j - 1;
        int endCol = j + 1 >= board[0].Length ? board[0].Length - 1 : j + 1;
        for (int m = startRow; m <= endRow; m++){
            for (int n = startCol; n <= endCol; n++){
                if (board[m][n] == 'M' || board[m][n] == 'X') mine++;
            }
        }
        if (mine != 0) board[i][j] = (char)(mine + '0');
        else {
            board[i][j] = 'B';
            dfs(board, i + 1, j);
            dfs(board, i - 1, j);
            dfs(board, i , j + 1);
            dfs(board, i , j - 1);
            dfs(board, i + 1 , j + 1);
            dfs(board, i + 1 , j - 1);
            dfs(board, i - 1 , j - 1);
            dfs(board, i - 1 , j + 1);
        }
    }
}



///BFS
public class Solution {
    public char[][] UpdateBoard(char[][] board, int[] click) {
        int m = board.Length;
        int n = board[0].Length;

        Queue q = new Queue();
        q.Enqueue(click);
        while (q.Count != 0){
            int[] cell = (int[])q.Dequeue();
            int row = cell[0];
            int col = cell[1];

            if (board[row][col] == 'M'){
                board[row][col] = 'X';
                break;
            }else{
                int count = 0;
                for (int i = -1; i < 2; ++i){
                    for (int j = -1; j < 2; ++j){
                        if (i == 0 && j == 0) continue;
                        int r = row + i;
                        int c = col + j;
                        if (r < 0 || c < 0 || r >= m || c >= n) continue;
                        if (board[r][c] == 'M' || board[r][c] == 'X') count++;
                    }
                }
                if (count > 0){
                    board[row][col] = (char)(count + '0');
                }else{
                    board[row][col] = 'B';
                    for (int i = -1; i < 2; ++i){
                        for (int j = -1; j < 2; ++j){
                            if (i == 0 && j == 0) continue;
                            int r = row + i;
                            int c = col + j;
                            if (r < 0 || c < 0 || r >= m || c >= n) continue;
                            if (board[r][c] == 'E'){
                                q.Enqueue(new int[]{r, c});
                                board[r][c] = 'B';
                            }
                        }
                    }
                }
            }
        }
        return board;
    }
}