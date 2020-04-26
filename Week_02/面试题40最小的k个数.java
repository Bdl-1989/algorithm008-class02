// https://leetcode-cn.com/problems/zui-xiao-de-kge-shu-lcof/solution/3chong-jie-fa-miao-sha-topkkuai-pai-dui-er-cha-sou/

//1. sort
//2. heap
//3. 快排


class Solution {
    public int[] getLeastNumbers(int[] arr, int k) {
        PriorityQueue<Integer> heap = new PriorityQueue<>();
        for (int i = 0; i < arr.length; ++ i){
            heap.add(arr[i]);
        }
        int[] ans = new int[k];
        for (int i = 0; i < k; ++i){
            ans[i] = heap.poll();
        }
        return ans;
    }
}

