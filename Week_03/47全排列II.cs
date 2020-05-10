//https://leetcode-cn.com/problems/permutations-ii/

// need review; format!

public class Solution
{

    public List<List<int>> res = new List<List<int>>();
    public List<List<int>> PermuteUnique(int[] nums)
    {

        if (nums == null || nums.Length == 0) return res;
        var used = new bool[nums.Length];
        var currentX = new List<int>();
        Array.Sort(nums);
        bt(nums, used, currentX);

        return res;

    }

    public void bt(int[] nums, bool[] used, List<int> currentX)
    {
        if (currentX.Count == nums.Length)
        {
            res.Add(new List<int>(currentX));
            return;
        }

        for (int i = 0; i < nums.Length;)
        {
            if (used[i]) continue;
            currentX.Add(nums[i]);
            used[i] = true;

            bt(nums, used, currentX);

            currentX.RemoveAt(currentX.Count - 1);
            used[i] = false;
			// skip all equal elements
            while (i < nums.Length - 1 && nums[i] == nums[i + 1])
            {
                i++;
            }
        }
    }
}