//https://leetcode-cn.com/problems/minimum-window-substring/


public class Solution {
    public string MinWindow(string s, string t) {
        int[] index = new int[128];
        int counter = t.Length;
        int head = 0, min = int.MaxValue;
        int left = 0, right = 0;
        foreach (var c in t)
        {
            index[c]++;
        }
        while(right < s.Length)
        {
            if (index[s[right]] > 0) counter--;
            index[s[right]]--;
            right++;
            while (counter == 0)
            {
                if (right - left < min)
                {
                    min = right - left;
                    head = left;
                }
                if (index[s[left]] == 0) counter++;
                index[s[left]]++;
                left++;
            }
        }
        return min == int.MaxValue ? "" : s.Substring(head, min);
    }
}