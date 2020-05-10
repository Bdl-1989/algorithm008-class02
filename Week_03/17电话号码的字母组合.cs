//https://leetcode-cn.com/problems/letter-combinations-of-a-phone-number/

public class Solution {
        //Assumption: All characters in the mapping are of lower case.
    private static readonly string[] Mapping = new string[]
    {
        string.Empty, string.Empty, "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz"
    };
    public IList<string> LetterCombinations(string digits)
    {
        List<string> res = new List<string>();
        if (string.IsNullOrEmpty(digits))
        {
            return res;
        }

        LetterCombinationsHelper(digits, string.Empty, 0, ref res);
        return res;
    }

    private static void LetterCombinationsHelper(string digits, string prefix, int offset, ref List<string> res)
    {
        //Base condition
        if (prefix.Length == digits.Length)
        {
            res.Add(prefix);
        }
        else
        {
            string mappedValues = Mapping[digits[offset] - '0'];
            for (int i = 0; i < mappedValues.Length; i++)
            {
                LetterCombinationsHelper(digits, prefix + mappedValues[i], offset + 1, ref res);
            }
        }
    }
}