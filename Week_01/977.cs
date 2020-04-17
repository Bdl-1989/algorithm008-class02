public class Solution {
    public int[] SortedSquares(int[] A) {
        int[] list = new int[A.Length];
        for(int i = 0, j = A.Length - 1, k = A.Length - 1; k >= 0; --k){
                list[k] = Math.Pow(A[i],2) > Math.Pow(A[j],2) ? (int)Math.Pow(A[i++],2) : (int)Math.Pow(A[j--],2);
        }
        return list;
    }
}