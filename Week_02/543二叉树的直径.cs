// https://leetcode-cn.com/problems/diameter-of-binary-tree/

// practice day: 4/25

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
    int ans;
    public int DiameterOfBinaryTree(TreeNode root) {
        ans = 1;
        depth(root);
        return ans - 1;
    }
    public int depth(TreeNode root){
        if (root == null) return 0;
        int left = depth(root.left);
        int right = depth(root.right);
        ans = Math.Max(left + right + 1, ans);
        return Math.Max(left, right) + 1;
    }
}