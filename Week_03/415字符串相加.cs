//https://leetcode-cn.com/problems/add-strings/

public class Solution {
    public string AddStrings(string num1, string num2) {
        StringBuilder res = new StringBuilder("");
        int i = num1.Length - 1, j = num2.Length - 1, carry = 0;
        while (i >= 0 || j >= 0){
            int n1 = i >= 0 ? num1[i] - '0' : 0;
            int n2 = j >= 0 ? num2[j] - '0' : 0;
            int tmp = n1 + n2 + carry;
            carry = tmp / 10;
            res.Insert(0,tmp % 10);
            --i;--j;
        }
        if (carry == 1) res.Insert(0, 1);
        return res.ToString();
    }
}