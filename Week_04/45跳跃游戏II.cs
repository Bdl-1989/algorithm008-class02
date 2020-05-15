//https://leetcode-cn.com/problems/jump-game-ii/


public class Solution {
    public int Jump(int[] nums) {
        int length = nums.Length;
        int end = 0;
        int maxPosition = 0;
        int steps = 0;
        for (int i = 0;i < length -1 ; ++i){
            maxPosition = Math.Max(maxPosition, i + nums[i]);
            if (i == end){
                end = maxPosition;
                ++ steps;
            }
        }
        return steps;
    }
}