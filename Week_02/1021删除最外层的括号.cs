//https://leetcode-cn.com/problems/remove-outermost-parentheses/submissions/

//stack

//practice day: 4/22


public class Solution {
    public string RemoveOuterParentheses(string S) {
        string str = "";
        int count = 0;
        foreach(char c in S){
            if (c == ')') --count;
            if (count >= 1) str += c;
            if (c == '(') ++count;      
        }
        return str;
    }
}


public class Solution {
    public string RemoveOuterParentheses(string S) {
        StringBuilder str = new StringBuilder();
        int num = 0;
        for (int i = 0; i < S.Length; i++) {
            if (S[i] == ')') {
                if (num != 1) str.Append(S[i]); 
                num = num - 1;
            } 
            else
            {
                if (num != 0) str.Append(S[i]); 
                num = num + 1;
            }
        }

        return str.ToString();
    }
}