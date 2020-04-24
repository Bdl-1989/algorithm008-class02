//https://leetcode-cn.com/problems/maximum-depth-of-n-ary-tree/submissions/


/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {
    public int MaxDepth(Node root) {
        if (root == null) return 0;
        if (root.children.Count() == 0) return 1;
        List<int> depth = new List<int>();
        foreach (var item in root.children){
            depth.Add(MaxDepth(item));
        }
        return depth.Count == 0 ? 1: depth.Max() + 1;
        //
    }
}