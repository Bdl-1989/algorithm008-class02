//https://leetcode-cn.com/problems/fizz-buzz/submissions/

//practice day: 4/23

public class Solution {
    public IList<string> FizzBuzz(int n) {
        IList<string> list = new List<string>();
        for (int i = 1; i <= n; ++i){
            if (i%15 == 0) {list.Add("FizzBuzz");continue;}
            if (i%3 == 0) {list.Add("Fizz");continue;}
            if (i%5 == 0) {list.Add("Buzz");continue;}
            list.Add(i.ToString());
        }
        return list;
    }
}