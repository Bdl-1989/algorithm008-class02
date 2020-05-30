//https://leetcode-cn.com/problems/burst-balloons/


public class Solution
    {
        int res = 0;
        bool[] isUsed;
        public int MaxCoins(int[] nums)
        {
            int[] dp = new int[nums.Length];
            isUsed = new bool[nums.Length];
            Array.Fill(isUsed, false);
            backTrack(0, dp, nums);
            return res;
        }
        private void backTrack(int count, int[] dp, int[] nums)
        {
            if (count == nums.Length)
            {
                int sum = 0;
                foreach (int item in dp)
                {
                    sum += item;
                }
                res = Math.Max(res, sum);
                return;
            }
            for (int i = 0; i < nums.Length; ++i)
            {
                if (isUsed[i] == true) continue;
                isUsed[i] = true;
                dp[i] = left(dp, nums, i) * nums[i] * right(dp, nums, i);
                count++;
                backTrack(count, dp, nums);
                dp[i] = 0;
                count--;
                isUsed[i] = false;
            }
        }
        private int left(int[] dp, int[] nums, int i)
        {
            for (int k = i - 1; k >= 0; k--)
            {
                if (isUsed[k] == false) return nums[k];
            }
            return 1;
        }
        private int right(int[] dp, int[] nums, int i)
        {
            for (int k = i + 1; k < nums.Length; k++)
            {
                if (isUsed[k] == false) return nums[k];
            }
            return 1;
        }
    }





public class Solution {
    public int MaxCoins(int[] nums) {
        int n = nums.Length;
        // 添加两侧的虚拟气球
        int[] points = new int[n + 2];
        points[0] = points[n + 1] = 1;
        for (int i = 1; i <= n; ++i) points[i] = nums[i - 1];
        // base case 已经都被初始化为 0
        int[][] dp = new int[n + 2][];
        for (int i = 0; i < n + 2; ++i) dp[i] = new int[n + 2];
        // 开始状态转移
        // i 应该从下往上
        for (int i = n; i >= 0; --i){
            // j 应该从左往右
            for (int j = i + 1; j < n + 2; ++j){
                // 最后戳破的气球是哪个？
                for (int k = i + 1; k < j; ++k){
                    // 择优做选择
                    dp[i][j] = Math.Max(dp[i][j], dp[i][k] + dp[k][j] + points[i] * points[k] * points[j]);
                }
            }
        }
        return dp[0][n + 1];