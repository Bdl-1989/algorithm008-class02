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



## 二分查找
- 目标函数单调性
- 存在上下界
- 能够通过索引访问

- 代码模板
```
left, right = 0, len(array) - 1 
while left <= right: 
	  mid = (left + right) / 2 
	  if array[mid] == target: 
		    # find the target!! 
		    break or return result 
	  elif array[mid] < target: 
		    left = mid + 1 
	  else: 
		    right = mid - 1

```



## 作业
- 使用二分查找，寻找一个半有序数组 [4, 5, 6, 7, 0, 1, 2] 中间无序的地方
说明：同学们可以将自己的思路、代码写在第 4 周的学习总结中

```
public class Solution {
    public int FindMin(int[] nums) {
        int left = 0;
        int right = nums.Length - 1;
        while (left < right){
            int mid = (left + right) / 2;
            if (nums[mid] > nums[right]) {
                left = mid + 1;
            }else right = mid;
        }
        return left;
    }
}
```


- 用二分法查找，需要始终将目标值（这里是最小值）套住，并不断收缩左边界或右边界。左、中、右三个位置的值相比较，有以下几种情况：
1. 左值 < 中值, 中值 < 右值 ：没有旋转，最小值在最左边，可以收缩右边界
 
2. 左值 > 中值, 中值 < 右值 ：有旋转，最小值在左半边，可以收缩右边界
 
3. 左值 < 中值, 中值 > 右值 ：有旋转，最小值在右半边，可以收缩左边界

 