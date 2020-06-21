//https://leetcode-cn.com/problems/serialize-and-deserialize-binary-tree/

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Codec {

    // Encodes a tree to a single string.
    public string serialize(TreeNode root) {
        return serial(new StringBuilder(), root).ToString();
    }
    public StringBuilder serial(StringBuilder str, TreeNode root){
        if (root == null) return str.Append("#");
        str.Append(root.val).Append(",");
        serial(str, root.left).Append(",");
        serial(str, root.right);
        return str;
    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data) {
        return deserial(new Queue<string>(data.Split(",")));
    }
    private TreeNode deserial(Queue<string> q){
        string val = q.Dequeue();
        if (val == "#") return null;
        TreeNode root = new TreeNode(Convert.ToInt32(val));
        root.left = deserial(q);
        root.right = deserial(q);
        return root;
    }
}

// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.deserialize(codec.serialize(root));