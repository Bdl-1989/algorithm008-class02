//https://leetcode-cn.com/problems/implement-trie-prefix-tree/


public class Trie {
    private bool isEnd;
    private Trie[] next;
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