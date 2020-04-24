//https://leetcode-cn.com/problems/binary-tree-preorder-traversal/submissions/

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
    public IList<int> PreorderTraversal(TreeNode root) {
        List<int> res = new List<int>();
        helper(root, res);
        return res;
    }
    public void helper(TreeNode root, List<int> res){
        if (root != null){
            res.Add(root.val);
            if (root.left != null) helper(root.left, res);
            if (root.right != null) helper(root.right, res);
        }
    }
}


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
    public IList<int> PreorderTraversal(TreeNode root) {
        List<int> res = new List<int>();
        Stack<TreeNode> stack = new Stack<TreeNode>();
        TreeNode curr = root;
        while (curr != null || stack.Count() != 0){  
            while (curr != null){
                res.Add(curr.val);
                stack.Push(curr);
                curr = curr.left;
            }
            curr = stack.Pop();
            curr = curr.right;
        }
        return res;
    }
}