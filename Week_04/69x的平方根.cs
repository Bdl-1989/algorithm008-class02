//https://leetcode-cn.com/problems/sqrtx/

//二分
public class Solution {
    public int MySqrt(int x) {
        if (x == 0 || x == 1) return x;
        long left = 1, right = (long)x;
        long mid = 1;
        while (left <= right) {
            mid = Convert.ToInt64((left + right) / 2.0);
            if (mid * mid > x) right = mid - 1;
            else left = mid + 1;
        }
        return (int)right;
    }
}

//牛顿迭代法



