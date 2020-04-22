//https://leetcode-cn.com/problems/sliding-window-maximum/
//https://leetcode-cn.com/problems/hua-dong-chuang-kou-de-zui-da-zhi-lcof/

//Queue

//practice day: 4/22

 public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        if (k == 0) return nums;
        int len = nums.Length;
        int maxArrayLen = len - k + 1;
        int[] ans = new int[maxArrayLen];
        LinkedList<int> q = new LinkedList<int>();
        for (int i = 0; i < len; ++i) {
            if (q.Count > 0 && q.First.Value + k <= i) q.RemoveFirst();
            while (q.Count > 0 && nums[q.Last.Value] <= nums[i]) q.RemoveLast();
            q.AddLast(i);
            int index = i + 1 - k;
            if (index >= 0) ans[index] = nums[q.First.Value];
        }
        return ans;
    }
}
//https://leetcode.com/problems/sliding-window-maximum/discuss/170002/C-optimal-solution-using-dequeue