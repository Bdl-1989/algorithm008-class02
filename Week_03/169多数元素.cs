//https://leetcode-cn.com/problems/majority-element/description/

public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int, int> dt = new Dictionary<int, int>();
        int count = 1;
        foreach (var n in nums) {
            if (dt.ContainsKey(n)) dt[n]++;
            else dt.Add(n, count);
        }
        foreach (var item in dt){
            if (item.Value > nums.Length/2) return item.Key;
        }
        return -1;
    }
}