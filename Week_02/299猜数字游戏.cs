//https://leetcode-cn.com/problems/bulls-and-cows/
//practice day: 4/20, 4/21

public class Solution {
    public string GetHint(string secret, string guess) {
        int bulls = 0;
        int cows = 0;
        int[] nums = new int[10];
        for (int i = 0; i < secret.Length; ++i) {
            if (secret[i] == guess[i]) ++bulls;
            else {
                if(nums[secret[i]-'0']++<0) ++cows;
                if(nums[guess[i]-'0']-->0) ++cows;
            }
        }
        return bulls+"A"+cows+"B";
    }
}