//https://leetcode-cn.com/problems/combinations/

public class Solution {
    public IList<IList<int>> Combine(int n, int k) {
        IList<IList<int>> res = new List<IList<int>>();
        NextList(res, n, new int[k], 0);
        return res;
    }
    internal void NextList(IList<IList<int>> lists, int n, int[] curr, int currlen){
        int k = curr.Length;
        if (currlen == k){
            lists.Add(new List<int>(curr));
            return;
        }
        int start = currlen == 0? 1 : curr[currlen - 1] + 1;
        int end = n - k + currlen + 1;
        for (int i = start; i <= end; ++i){
            curr[currlen] = i;
            NextList(lists, n, curr, currlen + 1);
        }
    }
}


