//https://leetcode-cn.com/problems/best-time-to-buy-and-sell-stock-ii/

public class Solution {
    public int MaxProfit(int[] prices) {
        int max = 0;
        for (int i = 1; i < prices.Length; ++i){
            if (prices[i] > prices[i - 1]) max += prices[i] - prices[i - 1];
        }
        return max;
    }
}