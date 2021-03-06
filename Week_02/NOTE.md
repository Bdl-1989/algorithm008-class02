学习笔记

## Need to practice
- 17.09


## 哈希表/映射/集合
### 哈希表
- 也叫散列表，是根据key值而直接进行访问的数据结构。具体通过将key映射到表中的位置来访问记录。映射函数叫做散列函数(hash function)，存放记录的数组叫哈希表。
- 工程实践：电话号码簿；用户信息表；缓存（LRU cache）；键值对存储（Redis）；区块链
- Hash collisions
- 查询性能接近O(1)，取决于有多少哈希碰撞。但可以通过良好设计避免。
- API：Java（HashMap/TreeMap/HashSet/TreeSet）
- https://docs.oracle.com/en/java/javase/12/docs/api/java.base/java/util/Set.html
- https://docs.oracle.com/en/java/javase/12/docs/api/java.base/java/util/Map.html

## 作业HashMap总结
### java
- https://docs.oracle.com/en/java/javase/12/docs/api/java.base/java/util/HashMap.html
- public class HashMap<K,​V> extends AbstractMap<K,​V> implements Map<K,​V>, Cloneable, Serializable
- 常用方法有：
> - clone()
> - containsKey()
> - get(key)
> - put(key, value)
> - remove(key)
> - size()

### C#
c#没有hashmap
- https://docs.microsoft.com/en-us/dotnet/api/system.collections.hashtable?view=netframework-4.8
- public class Hashtable : ICloneable, System.Collections.IDictionary, System.Runtime.Serialization.IDeserializationCallback, System.Runtime.Serialization.ISerializable
- 常用方法有：
> - Add(key,value)
> - Clone()
> - Contains(key)
> - Remove(key)
- hash collision in C#: https://stackoverflow.com/questions/2975612/what-happens-when-hash-collision-happens-in-dictionary-key


## 4/20
- C#: Hashtable
- C#: str.Split(",",StringSplitOptions.RemoveEmptyEntries);


## 4/21
- 切题四件套：1.clarification; 2.possible solution --> optimal (space & time); 3.code; 4.test cases

## 树/二叉树/二叉搜索树
- 树和图的差别
- 决策树
- 二叉树遍历
  1. 前序（Pre-order）:根-左-右
```
def preorder(self, root):
  if root:
    self.traverse_path.append(root.val)
    self.preorder(root.left)
    self.preorder(root.right)
```
  2. 中序（In-order）：左-根-右
```
def inorder(self, root):
  if root:
    self.inorder(root.left)
    self.traverse_path.append(root.val)
    self.inorder(root.right)
```
  3. 后序（Post-order）：左-右-根
```
def postorder(self, root):
  if root:
    self.postorder(root.left)
    self.postorder(root.right)
    self.traverse_path.append(root.val)
```

- 二叉搜索树 binary search tree，也称二叉排序树、有序二叉树 ordered binary tree、排序二叉树 Sorted binary tree，是指一颗空树或者具有下列性质的二叉树：
  1. 左子树上所有结点的值均小于它的根结点的值；
  2. 右子树上所有结点的值均大于它的根结点的值；
  3. 以此类推：左、右子树也分别为二叉查找树。（这是重复性）
  4. 中序遍历；升序排列
- 二叉搜索树常见操作：O(logN)
  1. 查询；
  2. 插入新结点（创建）；
  3. 删除；

- 思考：为什么树的面试题解法一般都是递归？
- Demo：https://visualgo.net/zh/bst?slide=1

- 树的解法一般是递归
  1. 容易调遍历函数


### 有两种通用的遍历树的策略：

#### 深度优先搜索（DFS）

- 在这个策略中，我们采用深度作为优先级，以便从跟开始一直到达某个确定的叶子，然后再返回根到达另一个分支。

- 深度优先搜索策略又可以根据根节点、左孩子和右孩子的相对顺序被细分为前序遍历，中序遍历和后序遍历。

- 宽度优先搜索（BFS）

- 我们按照高度顺序一层一层的访问整棵树，高层次的节点将会比低层次的节点先被访问到。
 


 ## 堆Heap和二叉堆Binary heap

- implement: https://shimo.im/docs/GpwwDq66kC9RC3PX/
### 堆Heap

- 定义: 可以迅速找到一堆数中的最大或者最小值的数据结构；
- 根节点最大的堆叫做大顶堆或者大根堆，根节点最小的堆叫小顶堆或者小根堆，常见的堆有二叉堆、斐波那契堆
- 大顶堆，常见API：
  1. find-max: O(1)
  2. delete-max: O(logN)
  3. insert(creat): O(logN) or O(1)


### 二叉堆: 又名优先队列priority_queue *(不是最优实现，但常见且简单)*

- 通过 <big>**完全二叉树**</big> 来实现；
- 二叉堆（大顶）满足下列性质：
  1. 是一个完全树
  2. 树中任意结点的值总是>=其子节点的值

- 二叉堆实现细节：
  1. 二叉堆一般都通过“数组”来实现；
  2. 假设“第一个元素”在数组中的索引为0的话，则父结点和子结点的位置关系如下：
       - 索引为i的左孩子的索引是(2*i + 1);
       - 索引为i的右孩子的索引是(2*i + 1);
       - 索引为i的父结点的索引是floor((i-1)/2);
  3. insert 插入操作：
       - 新元素一律先插入到堆的尾部；
       - 依次向上调整整个堆的结构 heapIfyUp
  4. delete 操作：
       - 将堆尾元素替换到顶部
       - 依次从根部向下调整整个堆的结构 heapIfyDown



## 4/25
- C#: 交叉数组new int[][]，赋值方式；二维数组new int[,]，赋值方式


## 图
- 用到越来越少
