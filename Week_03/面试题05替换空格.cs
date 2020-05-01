//https://leetcode-cn.com/problems/ti-huan-kong-ge-lcof/

public class Solution {
    public string ReplaceSpace(string s) {
        StringBuilder res = new StringBuilder();
        foreach (char c in s) {
            if (c == ' ') res.Append("%20");
            else res.Append(c);
        }
        return res.ToString();
    }
}


