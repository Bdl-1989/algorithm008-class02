public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int  i = m - 1, j = n - 1;
        if (m == 0){
            while (j >=0){
                nums1[j]=nums2[j];
                --j;
            }
        }else{
            for (int k = m + n - 1; j >= 0&&i>=0 ; --k){
                if(nums1[i] < nums2[j]){
                    nums1[k] =  nums2[j--];
                }else{
                    nums1[k] =  nums1[i--];
                }
            }
            while (j >=0){
                nums1[j]=nums2[j];
                --j;
            }
        }
    }
}