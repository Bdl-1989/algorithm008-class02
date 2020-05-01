//https://leetcode-cn.com/problems/cong-wei-dao-tou-da-yin-lian-biao-lcof/

public class Solution {
    public int[] ReversePrint(ListNode head) {
        if (head == null)
            return new int[0];

        head = reverse(head);
        List<int> list = new List<int>();
        while (head != null) {
            list.Add(head.val);
            head = head.next;
        }
        return list.ToArray();
    }
    internal ListNode reverse(ListNode node){
        if (node.next == null) return node;
        ListNode head = reverse(node.next);
        node.next.next = node;
        node.next = null;
        return head;
    }
}

public class Solution {
    public int[] ReversePrint(ListNode head) {
        Stack<int> st = new Stack<int>();
        while (head != null) {
            st.Push(head.val);
            head = head.next;
        }
        int count = st.Count;
        int[] res = new int[count];
        for (int i = 0; i < count; ++i){
            res[i] = st.Pop();
        }
        return res;
    }
}
