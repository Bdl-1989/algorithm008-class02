//https://leetcode-cn.com/problems/minimum-absolute-difference/

//暴力，遍历或者排序

//practice day: 4/25

public class Solution {
    public IList<IList<int>> MinimumAbsDifference(int[] arr) {
        Array.Sort(arr);
        IList<IList<int>> res = new List<IList<int>>();
        int min = Int32.MaxValue;
        for(int i = 0, j = i + 1; i < arr.Length - 1; ++i, ++j){
            if ((arr[j] - arr[i]) < min) {
                min = (arr[j] - arr[i]);
                res.Clear();
                res.Add(new List<int>{arr[i] , arr[j]});
            }else if ((arr[j] - arr[i]) == min){
                res.Add(new List<int>{arr[i] , arr[j]});
            }
        }
        return res;
    }
}