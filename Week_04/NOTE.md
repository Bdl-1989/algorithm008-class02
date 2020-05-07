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