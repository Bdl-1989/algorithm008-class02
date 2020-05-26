//https://leetcode-cn.com/problems/n-ary-tree-level-order-traversal/

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
    public IList<IList<int>> LevelOrder(Node root) {
        IList<IList<int>> ans = new List<IList<int>>();
        if (root == null) return ans;
        Queue<Node> q = new Queue<Node>();
        q.Enqueue(root);
        while (q.Count != 0){
            List<int> tmp = new List<int>();
            int size = q.Count;
            for (int i = 0; i < size; ++i){
                var node = q.Dequeue();
                tmp.Add(node.val);
                foreach (var c in node.children){
                    q.Enqueue(c);
                }
            }
            ans.Add(tmp);
        }
        return ans;
    }
}


