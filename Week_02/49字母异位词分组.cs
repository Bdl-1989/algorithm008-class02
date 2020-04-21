//https://leetcode-cn.com/problems/group-anagrams/

//1. dictionary/map， sort：O(NKlogK)
//2. 


public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
            IList<IList<string>> list = new List<IList<string>>();
            if (strs.Length == 0) return list;
            Dictionary<string, List<string>> ht = new Dictionary<string, List<string>>();
            foreach (var item in strs)
            {
                int[] buck = new int[26];
                string s = "";
                foreach (char c in item)
                {
                    ++buck[c - 'a'];
                }
                foreach (int b in buck)
                {
                    s += b.ToString();
                }
                if (!ht.ContainsKey(s))
                {
                    ht.Add(s, new List<string> { item });
                }
                ht[s].Add(item);
                
            }
            foreach (var item in ht)
            {
                list.Add(item.Value);
            }
            return list;
    }
}





    public class Solution
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            IList<IList<string>> res = new List<IList<string>>();
            Dictionary<int, int> map = new Dictionary<int, int>();
            int[] PRIMES = new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43,
            47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 107 };
            int count = 0;
            foreach (string str in strs)
            {
                int key = 1;
                foreach (char c in str) key *= PRIMES[(c - 'a')];
                if (!map.ContainsKey(key))
                {
                    map.Add(key, count++);
                    res.Add(new List<string>());
                }
                res[map[key]].Add(str);
            }
            return res;
        }
    }