class Solution {
    public char firstUniqChar(String s) {
        HashMap<Character, Boolean> dic = new HashMap<>();
        char[] sc = s.toCharArray();
        for(char c : sc)
            dic.put(c, !dic.containsKey(c));
        for(char c : sc)
            if(dic.get(c)) return c;
        return ' ';
    }

    public char prac(String s){
        HashMap<Character, Boolean> dic = new HashMap<>();
        char[] sc = s.toCharArray();
        for(char c : sc)
            dic.put(c, !dic.containsKey(c));
        for(char c : sc)
            if(dic.get(c)) return c;
        return ' ';
    }


}

class Solution {
    public char firstUniqChar(String s) {
        int ref = Integer.MAX_VALUE;
        for (char c = 'a'; c <= 'z'; c++){
            int index = s.indexOf(c);
            if (index != -1 && index == s.lastIndexOf(c)){
                ref = Math.min(ref, index);
            }
        }
        return ref == Integer.MAX_VALUE ? ' ': s.charAt(ref);
    }
}
 
    public class Solution
    {
        public char FirstUniqChar(string s)
        {
            int re = s.Length-1;
            for (char c = 'a'; c < 'z'; ++c)
            {
                int index = s.IndexOf(c);
                if (index != -1 && index == s.LastIndexOf(c))
                {
                    re = Math.Min(re, index);
                }
            }
            return re == s.Length-1 ? ' ' : s[re];
        }
    }