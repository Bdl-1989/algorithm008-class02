//https://leetcode-cn.com/problems/word-ladder/

public class Solution {
    public int LadderLength(string beginWord, string endWord, IList<string> wordList) {
        if (!wordList.Contains(endWord)) return 0;
        HashSet<string> visited = new HashSet<string>();
        Queue<string> queue = new Queue<string>();
        queue.Enqueue(beginWord);
        visited.Add(beginWord);
        int count = 0;
        while (queue.Count > 0){
            int size = queue.Count;
            ++count;
            for (int i = 0; i < size; ++i){
                string start = queue.Dequeue();
                foreach (var s in wordList){
                    if (visited.Contains(s)) continue;
                    if (!canConvert(start, s)) continue;
                    if (s == endWord) return count + 1;
                    visited.Add(s);
                    queue.Enqueue(s);
                }
            }
        }
        return 0;
    }
    public bool canConvert(string s1, string s2){
        if (s1.Length != s2.Length) return false;
        int count = 0;
        for (int i = 0; i < s1.Length; ++i){
            if (s1[i] != s2[i]){
                ++count;
                if (count > 1) return false;
            }
        }
        return count == 1;
    }
}

