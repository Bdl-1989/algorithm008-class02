//https://leetcode-cn.com/problems/kth-largest-element-in-an-array/

//https://leetcode.com/problems/kth-largest-element-in-an-array/discuss/562183/C-5-solutions-(Quick-Selection-Quick-Sort-Min-Heap-Dictionary-and-Array.Sort)



class Solution {
    public int FindKthLargest(int[] nums, int k) {
        SortedDictionary<int, int> minHeap = new SortedDictionary<int, int>();
        int heapSize = 0;
        foreach(var item in nums){
            if (minHeap.ContainsKey(item)) 
                minHeap[item]++;
            else 
                minHeap.Add(item, 1);
            heapSize++;

            if (heapSize > k){
                var min = minHeap.First();
                if (min.Value == 1) minHeap.Remove(min.Key);
                else minHeap[min.Key]--;
                heapSize--;
            }
        }
        return minHeap.First().Key;
    }
}