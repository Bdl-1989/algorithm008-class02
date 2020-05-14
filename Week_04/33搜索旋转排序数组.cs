//https://leetcode-cn.com/problems/search-in-rotated-sorted-array/




public class Solution {
    public int Search(int[] nums, int target) {
        if (nums.Length == 1 && nums[0] == target) return 0;
        else if(nums.Length == 1 && nums[0] != target) return -1;
        for (int i = 0, j = nums.Length - 1; i < j;){
            if (nums[i] == target) return i;
            if (nums[j] == target) return j;
            if (nums[i] < target) ++i;
            else if (nums[j] > target) --j;
            else return -1;
        }
        return -1;
    }
}