//https://leetcode-cn.com/problems/n-ary-tree-postorder-traversal/

//practice day:4/25


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
    List<int> list = new List<int>();
    public IList<int> Postorder(Node root) {
        if (root == null) return list;
        foreach (var node in root.children) Postorder(node);
        list.Add(root.val);
        return list;
    }
}