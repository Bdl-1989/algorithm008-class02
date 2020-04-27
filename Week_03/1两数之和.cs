//https://leetcode-cn.com/problems/two-sum/

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Array.Sort(nums);
        for (int i = 0, j = nums.Length - 1; i < j; ){
            if (nums[i] + nums[j] == target){
                return new int[2]{i,j};
            }else if(nums[i] + nums[j] > target){
                --j;
            }else{
                ++i;
            }
        }
        return null;
    }
}

//O(nLogn)


public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dt = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; ++i){
            int rest = target - nums[i];
            if (dt.ContainsKey(rest)) {
                return new int[]{dt[rest], i};
            }
            if (!dt.ContainsKey(nums[i])) dt.Add(nums[i], i);
        }
        return new int[] { 0, 0 };
    }
}

//O(n)