//https://leetcode-cn.com/problems/powx-n/

public class Solution {
    public double MyPow(double x, int n) {
        if (n < 0) {
            x = 1/x;
            n = - n;
        } 
        return fastPow(x, n);
    }
    internal double fastPow(double x, int n){
        if (n==0) return 1.0;
        double half = fastPow(x, n/2);
        return n%2 == 0 ? half * half : half * half * x;
    }
}