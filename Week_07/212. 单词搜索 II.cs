///https://leetcode-cn.com/problems/word-search-ii/


public class Solution {
    char[][] _board = null;
    List<string> _result = new List<string>();

    public IList<string> FindWords(char[][] board, string[] words) {
        Trie root = new Trie();
        foreach (string i in words){
            root.Insert(i);
        }
        _board = board;
        for (int i = 0; i < board.Length; ++i){
            for (int j = 0; j < board[0].Length; ++j){
                StringBuilder sb = new StringBuilder();
                backTracking(i, j, sb, root);
            }
        }
        return _result;
    }
    private void backTracking(int row, int col, StringBuilder sb, Trie node){
        if (row >= _board.Length || row < 0 || col >= _board[0].Length || col < 0) return;
        char cur = _board[row][col];
        if (cur == '$' || node.next[cur - 'a'] == null) return;
        sb.Append(cur);
        node = node.next[cur - 'a'];
        if (node.isEnd && !_result.Contains(sb.ToString())) _result.Add(sb.ToString());
        
        _board[row][col] = '$';
        backTracking(row + 1, col, sb, node);
        backTracking(row - 1, col, sb, node);
        backTracking(row, col + 1, sb, node);
        backTracking(row, col - 1, sb, node);
        _board[row][col] = cur;
        sb.Remove(sb.ToString().Length - 1, 1);
    }
}
public class Trie {
    public bool isEnd;
    public Trie[] next;
    /** Initialize your data structure here. */
    public Trie() {
        isEnd = false;
        next = new Trie[26];
    }
    
    /** Inserts a word into the trie. */
    public void Insert(string word) {
        if (word == null || word.Length == 0) return;
        Trie curr = this;
        char[] words = word.ToCharArray();
        for (int i = 0; i < words.Length; ++i){
            int tmp = words[i] - 'a';
            if (curr.next[tmp] == null) curr.next[tmp] = new Trie();
            curr = curr.next[tmp];
        }
        curr.isEnd = true;
    }
    
    /** Returns if the word is in the trie. */
    public bool Search(string word) {
        Trie node = searchPrefix(word);
        return node != null && node.isEnd;
    }
    
    /** Returns if there is any word in the trie that starts with the given prefix. */
    public bool StartsWith(string prefix) {
        Trie node = searchPrefix(prefix);
        return node != null;
    }

    public Trie searchPrefix(string word){
        Trie node = this;
        char[] words = word.ToCharArray();
        for (int i = 0; i < words.Length; ++i ){
            node = node.next[words[i] - 'a'];
            if (node == null) return null;
        }
        return node;
    }

}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */