//https://leetcode-cn.com/problems/merge-k-sorted-lists/solution/4-chong-fang-fa-xiang-jie-bi-xu-miao-dong-by-sweet/

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode MergeKLists(ListNode[] lists) {
        ListNode res = null;
        foreach (var list in lists){
            res = merge2Lists(res, list);
        }
        return res;
    }
    private ListNode merge2Lists(ListNode l1, ListNode l2) {
    if (l1 == null) {
        return l2;
    }
    if (l2 == null) {
        return l1;
    }
    if (l1.val < l2.val) {
        l1.next = merge2Lists(l1.next, l2);
        return l1;
    }
    l2.next = merge2Lists(l1, l2.next);
    return l2;
    }

 
}