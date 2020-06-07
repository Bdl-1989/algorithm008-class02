//https://leetcode-cn.com/problems/minimum-genetic-mutation/

public class Solution {
    public int MinMutation(string start, string end, string[] bank) {
        Queue q = new Queue();
        char[] chars = {'A','C','G','T'};
        HashSet<string> bankSet = new HashSet<string>();
        int level = 0;
        q.Enqueue(start);
        foreach(string s in bank) bankSet.Add(s);
        while (q.Count != 0){
            int count = q.Count;
            while (count-- > 0){
                string currString = (string)q.Dequeue();
                if (currString == end) return level;
                for (int i = 0; i < currString.Length; ++i){
                    foreach (char c in chars){
                        char[] currChars = currString.ToCharArray();
                        currChars[i] = c;
                        String modString = new String(currChars);
                        if (bankSet.Contains(modString)){
                            q.Enqueue(modString);
                            bankSet.Remove(modString);
                        }
                    }
                }
            }
            level++;
        }
        return -1;
    }
}


