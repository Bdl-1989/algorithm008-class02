///https://leetcode-cn.com/problems/triangle/solution/120-san-jiao-xing-zui-xiao-lu-jing-he-by-alexer-66/


public class Solution {
    public int MinimumTotal(IList<IList<int>> triangle) {
        var dp = new int[triangle.Count + 1];
        Array.Fill(dp, 0);
        for (var i = triangle.Count - 1; i >= 0; --i){
            for (var j = 0; j < triangle[i].Count; ++j){
                dp[j] = Math.Min(dp[j], dp[j + 1]) + triangle[i][j];
            }
        }
        return dp[0];
    }
}