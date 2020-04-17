public class Solution {
    public void Rotate(int[] nums, int k) {
        k %= nums.Length;
        Reverse(nums, 0, nums.Length - 1);
        Reverse(nums, 0, k - 1);
        Reverse(nums, k, nums.Length - 1);
    }
    public void Reverse(int[] nums, int l, int r){
        int tmp;
        while (l < r){
            tmp = nums[r];
            nums[r--] = nums[l];
            nums[l++] = tmp;
        }
    }
}