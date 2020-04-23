//https://leetcode-cn.com/problems/add-digits/

//递归

//practice day: 4/23

public class Solution {
    public int AddDigits(int num) {
        return (num - 1) % 9 + 1;
    }
}