//https://leetcode-cn.com/problems/generate-parentheses/

class Solution {
    private List<String> res;
    public List<String> generateParenthesis(int n) {
        res = new ArrayList<String>();
        _generate(0, 0, n, "");
        return res;
    }
    public void _generate(int left, int right, int n, String s){
        //terminator
        if (left == n && right == n) res.add(s);
        //process
        String s1 = s + "(";
        String s2 = s + ")";
        //drill down
        if (left < n)
            _generate(left + 1, right, n, s1);
        if (right < left)
             _generate(left, right + 1, n, s2);
        //reverse states
    }
}
public class Solution {
    private List<string> res;
    public IList<string> GenerateParenthesis(int n) {
        res = new List<string>();
        _generate(0, 0, n, "");
        return res;
    }
    internal void _generate(int left, int right, int n, string str){
        //terminator
        if (left == n && right == n) {res.Add(str); return ;}
        //process
        string s1 = str + "(";
        string s2 = str + ")";
        //drill down
        if (left < n)
            _generate(left + 1, right, n, s1);
        if(right < left)
            _generate(left, right + 1, n, s2);
        //reverse


    }
}
