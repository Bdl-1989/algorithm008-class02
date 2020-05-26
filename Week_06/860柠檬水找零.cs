//https://leetcode-cn.com/problems/lemonade-change/


public class Solution {
    public bool LemonadeChange(int[] bills) {
        int[] count = new int[3];
        foreach (int b in bills) {
            count[b/10]++;
            int change = b-5;
            while (change > 0) {
                int index = change/10;
                while (index >= 0 && count[index] == 0)
                    index--;
                if (index < 0)
                    return false;
                count[index]--;
                change -= 5*(index+1);
            }
        }
        return true;
    }
}