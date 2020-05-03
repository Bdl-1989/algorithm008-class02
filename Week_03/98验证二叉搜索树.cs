// https://leetcode-cn.com/problems/validate-binary-search-tree/

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
    public bool IsValidBST(TreeNode root) {
        return helper(root, Int64.MaxValue, Int64.MinValue);
    }
    internal bool helper(TreeNode root, long max, long min){
        if(root == null) return true;
        if (!(root.val > min && root.val < max)) return false;
 
        return helper(root.left, root.val, min) && helper(root.right, max, root.val);
    }
}