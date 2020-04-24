//https://leetcode-cn.com/problems/minimum-depth-of-binary-tree/


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
    public int MinDepth(TreeNode root) {
        if (root == null) return 0;
        if (root.left == null && root.right == null) return 1;
        int left = MinDepth(root.left);
        int right = MinDepth(root.right);
        if (root.left == null || root.right == null) return left + right + 1;
        return Math.Min(left, right) + 1;
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
    public int MinDepth(TreeNode root) {
        if (root == null) return 0;
        if (root.left == null) return MinDepth(root.right) + 1;
        if (root.right == null) return MinDepth(root.left) + 1;
        return Math.Min(MinDepth(root.left), MinDepth(root.right)) + 1;
    }
}