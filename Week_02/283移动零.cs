public class Solution {
    public void MoveZeroes(int[] nums) {
        int tmp = 0;
        for (int i = 0, j = 0; i < nums.Length; ++i){
            if (nums[i] != 0){
                tmp = nums[i];
                nums[i] = nums[j];
                nums[j++] = tmp;
            }
        }
    }
}