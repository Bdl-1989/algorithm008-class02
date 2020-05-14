学习笔记

## 深度优先搜索和广度优先搜索
- 搜索：遍历
- - 每个节点都要访问一次
- - 每个节点仅仅访问一次
- - 对于节点访问顺序不限： 深度优先和广度优先； 优先级优先（启发式搜索/深度学习）
### 深度优先
- 递归写法
```
visited = set() 

def dfs(node, visited):
    if node in visited: # terminator
    	# already visited 
    	return 

	visited.add(node) 

	# process current node here. 
	...
	for next_node in node.children(): 
		if next_node not in visited: 
			dfs(next_node, visited)

```

```
def dfs(node):
    if node in visited:
        # already visited
        return
    
    visited.add(node)

    # process current node
    # .. # logic here
    dfs(node.left)
    dfs(node.right)
```

- 非递归写法

```
def DFS(self, tree): 

	if tree.root is None: 
		return [] 

	visited, stack = [], [tree.root]

	while stack: 
		node = stack.pop() 
		visited.add(node)

		process (node) 
		nodes = generate_related_nodes(node) 
		stack.push(nodes) 

	# other processing work 
	...
```
### 广度优先遍历
- 用队列
```
def BFS(graph, start, end):
    visited = set()
	queue = [] 
	queue.append([start]) 

	while queue: 
		node = queue.pop() 
		visited.add(node)

		process(node) 
		nodes = generate_related_nodes(node) 
		queue.push(nodes)

	# other processing work 
	...
```



## Greedy 贪心算法
- 在每一步选择中都采取在当前状态下最好或最优的选择，从而希望导致结果是全局最好或最优的宣发。
- 与动态规划不同在于其对每个子问题的解决方案都做出选择，不能回退。动态规划则会保存以前的运算结果，并根据以前的结果对当前进行选择，有回退功能。


- 贪心：当下做局部最优判断
- 回溯：能够回退
- 动态规划：最优判断 + 回退 （保存结果）

- 贪心可以解决一些最优化问题， 如求图中的最小生成树， 求哈夫曼编码等。然而对于工程和生活中的问题，贪心法一般不能得到我们所要的结果。
- 贪心可以作为辅助算法或者求解一些要求结果不特别精确的问题
- 