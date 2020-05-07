//https://leetcode-cn.com/problems/minesweeper/submissions/


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