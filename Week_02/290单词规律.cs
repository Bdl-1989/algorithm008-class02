//https://leetcode-cn.com/problems/word-pattern/
//practice day: 4/20, 4/21
    public class Solution
    {
        public bool WordPattern(string pattern, string str)
        {
            string[] s = str.Split(" ");
            if (s.Length != pattern.Length) return false;
            Hashtable ht = new Hashtable();
            for (int i = 0; i < pattern.Length; ++i)
            {
                if(!ht.Contains(pattern[i]))
                {
                    if (ht.ContainsValue(s[i])) return false;
                    ht[pattern[i]] = s[i];
                }
                else
                {
                    if (ht[pattern[i]].ToString() != s[i]) return false;
                }
            }
            return true;
        }
    }