//https://leetcode-cn.com/problems/invert-binary-tree/submissions/

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
    public TreeNode InvertTree(TreeNode root) {
        if (root == null) return null;
        TreeNode right = InvertTree(root.right);
        TreeNode left = InvertTree(root.left);
        root.right = left;
        root.left = right;
        return root;
    }
}