//https://leetcode-cn.com/problems/number-of-1-bits/

public class Solution {
    public int HammingWeight(uint n) {
        int count = 0;
        int mask = 1;
        for (int i = 0; i < 32; ++i){
            if ((n & mask) != 0) count++;
            mask <<= 1;
        }
        return count;
    }
}