/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
        public ListNode SwapPairs(ListNode head)
        {
            ListNode dummy = new ListNode(-1);
            dummy.next = head;
            ListNode pre = dummy;
            while (head!=null&&head.next!=null){
                ListNode n1 = head;
                ListNode n2 = head.next;

                pre.next = n2;
                n1.next = n2.next;
                n2.next = n1;

                pre = n1;
                head = n1.next;
            }
            return dummy.next;
        }
}