
//https://leetcode-cn.com/problems/search-in-rotated-sorted-array/

public class Solution {
    public int Search(int[] nums, int target) {
        if (nums.Length == 1 && target == nums[0]) return 0;
        else if (nums.Length == 1 && target != nums[0]) return -1;
        for (int i = 0, j = nums.Length - 1; i < j; ){
            if (target == nums[i]) return i;
            if (target == nums[j]) return j;
            if (target < nums[j]) --j;
            else if (target > nums[i]) ++i;
            else return -1;
        }
        return -1;
    }
}