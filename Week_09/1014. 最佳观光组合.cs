//https://leetcode-cn.com/problems/best-sightseeing-pair/



public class Solution {
    public int MaxScoreSightseeingPair(int[] A) {
        int ans = - A.Length, mi = A[0] + 0;
        for (int j = 1; j < A.Length; ++j){
            ans = Math.Max(ans, mi + A[j] - j);
            mi = Math.Max(mi, A[j] + j);
        }
        return ans;
    }
}