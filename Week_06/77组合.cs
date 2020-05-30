//https://leetcode-cn.com/problems/combinations/

public class Solution {
    IList<IList<int>> res = new List<IList<int>>();
    public IList<IList<int>> Combine(int n, int k) {
        if (k <= 0 || n <= 0) return res;
        Stack<int> track = new Stack<int>();
        backTrack(n, k, 1, track);
        return res;
    }
    private void backTrack(int n, int k, int start, Stack<int> track){
        // 到达树的底部
        if (k == track.Count){
            res.Add(new List<int>(track));
            return;
        }
        // 注意 i 从 start 开始递增
        for (int i = start; i <= n; ++i){
            track.Push(i);
            backTrack(n, k, i + 1, track);
            track.Pop();
        }
    }
}

