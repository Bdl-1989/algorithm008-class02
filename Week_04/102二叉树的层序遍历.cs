//https://leetcode-cn.com/problems/binary-tree-level-order-traversal/#/description


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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        if (root == null) return new List<IList<int>>();
        IList<IList<int>> res = new List<IList<int>>();
        Queue q = new Queue();
        q.Enqueue(root);
        while (q.Count > 0){
            int size = q.Count;
            List<int> tmp = new List<int>();
            for (int i = 0; i < size; ++i){
                TreeNode t = (TreeNode)q.Dequeue();
                tmp.Add(t.val);
                if (t.left!= null) q.Enqueue(t.left);
                if(t.right != null) q.Enqueue(t.right);
            }
            res.Add(tmp);
        }
        return res;
    }
}