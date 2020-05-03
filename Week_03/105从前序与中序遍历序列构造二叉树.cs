//https://leetcode-cn.com/problems/construct-binary-tree-from-preorder-and-inorder-traversal/

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
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        return helper(0, 0, inorder.Length - 1, preorder, inorder);
    }
    internal TreeNode helper(int preStart, int inStart, int inEnd, int[] preorder, int[] inorder){
        if (preStart > preorder.Length - 1 || inStart > inEnd) return null;
        TreeNode root = new TreeNode(preorder[preStart]);
        int inIndex = 0;
        for (int i = inStart; i <= inEnd; ++i){
            if (inorder[i] == root.val) inIndex = i; 
        }
        root.left = helper(preStart + 1, inStart, inIndex - 1, preorder, inorder);
        root.right = helper(preStart + 1 + (inIndex - inStart), inIndex + 1, inEnd, preorder,inorder);
        return root;
    }
}


