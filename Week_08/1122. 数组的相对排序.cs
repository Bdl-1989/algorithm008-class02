//https://leetcode-cn.com/problems/relative-sort-array/

public class Solution {
    public int[] RelativeSortArray(int[] arr1, int[] arr2) {
       int[] m = new int[1001];
       int[] refer = new int[arr1.Length];
       for (int i = 0; i < arr1.Length; ++i){
           m[arr1[i]]++;
       } 
       int cnt = 0;
       for (int i = 0; i < arr2.Length; ++i){
           while (m[arr2[i]] > 0){
               refer[cnt++] = arr2[i];
               m[arr2[i]]--;
           }
       }
       for (int i = 0; i < 1001; ++i){
           while (m[i] > 0){
               refer[cnt++] = i;
               m[i]--;
           }
       }
       return refer;
    }
}