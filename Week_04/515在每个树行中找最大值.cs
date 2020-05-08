//https://leetcode-cn.com/problems/find-largest-value-in-each-tree-row/

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public IList<int> LargestValues(TreeNode root) {
        IList<int> res = new List<int>();
        if (root == null) return res;
        Queue q = new Queue();
        q.Enqueue(root);
        while (q.Count != 0){
            int count = q.Count;
            TreeNode max = (TreeNode)q.Peek();
            for (int i = 0; i < count; i++){
                TreeNode t =(TreeNode)q.Dequeue();
                if (max.val < t.val) {
                    max = t;
                }
                if (t.left != null) q.Enqueue(t.left);
                if (t.right != null) q.Enqueue(t.right);
            }
            res.Add(max.val);
        }
        return res;
    }
}