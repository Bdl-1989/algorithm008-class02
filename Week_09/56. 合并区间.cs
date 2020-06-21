//https://leetcode-cn.com/problems/merge-intervals/

public class Solution {
    public int[][] Merge(int[][] intervals) {
        int n = intervals.Length;
        if (n <= 1) return intervals;
        Array.Sort(intervals, (a, b) => a[0] - b[0]);
        List<int[]> res = new List<int[]>();
        res.Add(intervals[0]);
        for (int i = 1; i < n; ++i){
            int[] cur = intervals[i];
            int[] lastFromResult = res.Last();
            if (lastFromResult[1] >= cur[0]){
                lastFromResult[1] = Math.Max(lastFromResult[1], cur[1]);
            }else{
                res.Add(cur);
            }
        }
        return res.ToArray();
    }
}