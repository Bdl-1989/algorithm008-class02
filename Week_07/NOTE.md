学习笔记
## 总结

https://shimo.im/mindmaps/8ydRRTDw6ckGQy3G/ 

- 字典树多用于搜索和补全
- 并查集多用于合并和查找
- 剪枝、双向bfs和启发性搜索
- 其中，我认为启发性搜索是有用，可以安装事先定义的策略进行定向、快速搜索。如果可以熟练掌握模板，就可以很好的应用到平时工作中。

- 双向bfs求java或者c#模板，网上的又臭又长，时间也不够。

## 字典树 Trie
- 典型应用：用于统计和排序大量字符串、单词补全功能、搜索引擎
- 优点：最大限度地减少无谓的字符串比较，查询效率比哈希表高
### 字典树的数据结构



### 字典树的核心思想

### 字典树的基本性质
- 结点本身不存完整单词；
- 从根结点到某一结点，路径上经过的字符连接起来，为该结点对应的字符串
- 每个结点的所有子结点路径代表的字符都不相同

```
Java
class Trie {
    private boolean isEnd;
    private Trie[] next;
    /** Initialize your data structure here. */
    public Trie() {
        isEnd = false;
        next = new Trie[26];
    }
    
    /** Inserts a word into the trie. */
    public void insert(String word) {
        if (word == null || word.length() == 0) return;
        Trie curr = this;
        char[] words = word.toCharArray();
        for (int i = 0;i < words.length;i++) {
            int n = words[i] - 'a';
            if (curr.next[n] == null) curr.next[n] = new Trie();
            curr = curr.next[n];
        }
        curr.isEnd = true;
    }
    
    /** Returns if the word is in the trie. */
    public boolean search(String word) {
        Trie node = searchPrefix(word);
        return node != null && node.isEnd;
    }
    
    /** Returns if there is any word in the trie that starts with the given prefix. */
    public boolean startsWith(String prefix) {
        Trie node = searchPrefix(prefix);
        return node != null;
    }

    private Trie searchPrefix(String word) {
        Trie node = this;
        char[] words = word.toCharArray();
        for (int i = 0;i < words.length;i++) {
            node = node.next[words[i] - 'a'];
            if (node == null) return null;
        }
        return node;
    }
}
```


```
# Python 
class Trie(object):
  
	def __init__(self): 
		self.root = {} 
		self.end_of_word = "#" 
 
	def insert(self, word): 
		node = self.root 
		for char in word: 
			node = node.setdefault(char, {}) 
		node[self.end_of_word] = self.end_of_word 
 
	def search(self, word): 
		node = self.root 
		for char in word: 
			if char not in node: 
				return False 
			node = node[char] 
		return self.end_of_word in node 
 
	def startsWith(self, prefix): 
		node = self.root 
		for char in prefix: 
			if char not in node: 
				return False 
			node = node[char] 
		return True
```


## 并查集 disjoint set-

- 使用场景：组团/配对
### 基本操作
- makeSet(x)
- unionSet(x, y)
- find(x)


```
// Java
class UnionFind { 
	private int count = 0; 
	private int[] parent; 
	public UnionFind(int n) { 
		count = n; 
		parent = new int[n]; 
		for (int i = 0; i < n; i++) { 
			parent[i] = i;
		}
	} 
	public int find(int p) { 
		while (p != parent[p]) { 
			parent[p] = parent[parent[p]]; 
			p = parent[p]; 
		}
		return p; 
	}
	public void union(int p, int q) { 
		int rootP = find(p); 
		int rootQ = find(q); 
		if (rootP == rootQ) return; 
		parent[rootP] = rootQ; 
		count--;
	}
}
```


```
# Python 

def init(p): 
	# for i = 0 .. n: p[i] = i; 
	p = [i for i in range(n)] 
 
def union(self, p, i, j): 
	p1 = self.parent(p, i) 
	p2 = self.parent(p, j) 
	p[p1] = p2 
 
def parent(self, p, i): 
	root = i
	while p[root] != root: 
		root = p[root] 
	while p[i] != i: # 路径压缩 ?
		x = i; i = p[i]; p[x] = root 
	return root
```


## 高级搜索

- 剪纸
- 双向BFS
- 启发式搜索

### 初级搜索/傻搜

- 朴素搜索
- 优化方向：不重复（fibonacci）、剪枝（括号）
- 搜索方向：
- a. DFS
- b. BFS
- c. 双向搜索、启发式搜索


### 双向BFS


### 启发性搜索/ Astar/ A*

```
# Python
def AstarSearch(graph, start, end):

	pq = collections.priority_queue() # 优先级 —> 估价函数
	pq.append([start]) 
	visited.add(start)

	while pq: 
		node = pq.pop() # can we add more intelligence here ?
		visited.add(node)

		process(node) 
		nodes = generate_related_nodes(node) 
        unvisited = [node for node in nodes if node not in visited]
		pq.push(unvisited)

```
https://zxi.mytechroad.com/blog/searching/8-puzzles-bidirectional-astar-vs-bidirectional-bfs/

https://dataaspirant.com/2015/04/11/five-most-popular-similarity-measures-implementation-in-python/




## 高级树/AVL树/红黑树

### avl树
- 平衡二叉搜索树

### 红黑树
- 近似平衡二叉搜索树
- 满足条件：
- -a. 每个结点要么是红色，要么是黑色
- b. 根结点是黑色
- c. 每个叶结点（NIL结点、空结点）是黑色的
- d. 不能有相邻接的两个红色结点
- e. 从任一结点到其每个叶子的所有路径都包含相同数目的黑色结点
