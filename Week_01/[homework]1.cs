public class Solution {
    // private int[] results;
    public int[] TwoSum(int[] nums, int target) {
        int[] results=new int[2];
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i+1; j < nums.Length; j++)
            {
                if (nums[i]+nums[j]==target)
                {
                    results[0]=i;
                    results[1]=j;
                }
            }
        }
        return results;
    }
}