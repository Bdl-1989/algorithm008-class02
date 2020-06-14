//  https://leetcode-cn.com/problems/reverse-pairs/

public class Solution
{
    int[] arr;
    int res;
    public int ReversePairs(int[] nums)
    {
        res = 0;
        arr = nums;
        MergeSort(0, nums.Length - 1);
        return res;
    }
    public void MergeSort(int left, int right)
    {
        if (left >= right) return;
        int mid = (left + right) >> 1;
        MergeSort(left, mid);
        MergeSort(mid + 1, right);
        Count(left, mid, right);
        Merge(left, mid, right);

    }

    private void Count(int left, int mid, int right)
    {
        int i = left, j = mid + 1;
        int count = 0;
        while (i <= mid)
        {
            if (j > right || (long)arr[i] <= 2 * (long)arr[j])
            {
                i++;
                res += count;
            }
            else
            {
                j++;
                count++;
            }
        }
    }

    private void Merge(int left, int mid, int right)
    {
        int[] temp = new int[right - left + 1];
        int i = left, j = mid + 1, k = 0;
        while (i <= mid && j <= right) temp[k++] = arr[i] <= arr[j] ? arr[i++] : arr[j++];

        while (i <= mid) temp[k++] = arr[i++];
        while (j <= right) temp[k++] = arr[j++];

        for (int p = 0; p < temp.Length; ++p)
        {
            arr[left + p] = temp[p];
        }
    }
}