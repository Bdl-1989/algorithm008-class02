// https://leetcode-cn.com/problems/reverse-string-ii/


public class Solution {
    public string ReverseStr(string s, int k) {
        char[] arr = s.ToCharArray();
        for (int left = 0, step = 2 * k; left < arr.Length - 1; left += step){
            int right = Math.Min(arr.Length - 1, left + k - 1);
            Swap(arr, left, right);
        }
        return new String(arr);
    }
    private void Swap(char[] arr, int left, int right){
        while( left < right){
            char tmp = arr[left];
            arr[left++] = arr[right];
            arr[right--] = tmp;
        }
    }
}