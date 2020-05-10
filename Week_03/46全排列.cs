//https://leetcode-cn.com/problems/permutations/

public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
        IList<IList<int>> res = new List<IList<int>>();
        helper(nums.ToList(), new List<int>(), res);
        return res;
    }  
    internal void helper(List<int> nums, List<int> choose, IList<IList<int>> res){
        if (nums.Count == 0) res.Add(choose.ToArray());
        else{
            for(int index = 0; index < nums.Count; ++index){
                //choose
                int num = nums[index];
                nums.RemoveAt(index);
                choose.Add(num);
                //explore
                helper(nums, choose, res);
                //unchoose
                choose.Remove(num);
                nums.Insert(index, num);
            }
        }
    } 
}