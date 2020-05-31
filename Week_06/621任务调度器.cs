//https://leetcode-cn.com/problems/task-scheduler/

public class Solution {
    public int LeastInterval(char[] tasks, int n) {
        char maxChar = ' ';
        Dictionary<char, int> dt = new Dictionary<char, int>();
        foreach (char c in tasks){
            if (dt.ContainsKey(c)) dt[c]++;
            else dt.Add(c, 1);
            if (maxChar == ' ') maxChar = c;
            if (dt[maxChar] < dt[c]) maxChar = c;
        }
        int rest = 0;
        foreach (var item in dt) if (item.Value == dt[maxChar]) rest++;
        return Math.Max((dt[maxChar] - 1) * (n + 1) + rest, tasks.Length); 
        
    }
}