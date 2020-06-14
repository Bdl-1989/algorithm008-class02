学习笔记
- 树状数组

## 位运算



## 布隆过滤器 Bloom filter
- 应用：比特币网络/分布式系统/Redis缓存/垃圾邮件、评论过滤等
-https://blog.csdn.net/tianyaleixiaowu/article/details/74721877

```
https://github.com/lovasoa/bloomfilter/blob/master/src/main/java/BloomFilter.java
```

## LRU Cache
- least recently used
- 两个要素：大小、替换策略
- 实现：HashTable + DoubleLinkedList

```
class LRUCache {
    /**
     * 缓存映射表
     */
    private Map<Integer, DLinkNode> cache = new HashMap<>();
    /**
     * 缓存大小
     */
    private int size;
    /**
     * 缓存容量
     */
    private int capacity;
    /**
     * 链表头部和尾部
     */
    private DLinkNode head, tail;

    public LRUCache(int capacity) {
        //初始化缓存大小，容量和头尾节点
        this.size = 0;
        this.capacity = capacity;
        head = new DLinkNode();
        tail = new DLinkNode();
        head.next = tail;
        tail.prev = head;
    }

    /**
     * 获取节点
     * @param key 节点的键
     * @return 返回节点的值
     */
    public int get(int key) {
        DLinkNode node = cache.get(key);
        if (node == null) {
            return -1;
        }
        //移动到链表头部
        moveToHead(node);
        return node.value;
    }

    /**
     * 添加节点
     * @param key 节点的键
     * @param value 节点的值
     */
    public void put(int key, int value) {
        DLinkNode node = cache.get(key);
        if (node == null) {
            DLinkNode newNode = new DLinkNode(key, value);
            cache.put(key, newNode);
            //添加到链表头部
            addToHead(newNode);
            ++size;
            //如果缓存已满，需要清理尾部节点
            if (size > capacity) {
                DLinkNode tail = removeTail();
                cache.remove(tail.key);
                --size;
            }
        } else {
            node.value = value;
            //移动到链表头部
            moveToHead(node);
        }
    }

    /**
     * 删除尾结点
     *
     * @return 返回删除的节点
     */
    private DLinkNode removeTail() {
        DLinkNode node = tail.prev;
        removeNode(node);
        return node;
    }

    /**
     * 删除节点
     * @param node 需要删除的节点
     */
    private void removeNode(DLinkNode node) {
        node.next.prev = node.prev;
        node.prev.next = node.next;
    }

    /**
     * 把节点添加到链表头部
     *
     * @param node 要添加的节点
     */
    private void addToHead(DLinkNode node) {
        node.prev = head;
        node.next = head.next;
        head.next.prev = node;
        head.next = node;
    }

    /**
     * 把节点移动到头部
     * @param node 需要移动的节点
     */
    private void moveToHead(DLinkNode node) {
        removeNode(node);
        addToHead(node);
    }

    /**
     * 链表节点类
     */
    private static class DLinkNode {
        Integer key;
        Integer value;
        DLinkNode prev;
        DLinkNode next;

        DLinkNode() {
        }

        DLinkNode(Integer key, Integer value) {
            this.key = key;
            this.value = value;
        }
    }
}
```


## 排序
- 高级
### 快速排序
- 数组取标杆pivot，将小元素放pivot左边，大元素放右侧，然后依次对右边和左边的子数组继续快排；以达到整个序列有序。


### 归并排序
- 把长度为n的输入序列分为两个长度为n/2的子序列
- 对者两个子序列分别采用归并排序
- 将两个排序好的子序列合并成一个最终的排序序列

### 堆排序
- 插入O(logN),取最值O(1)
- 数组元素依次建立小顶堆
- 依次取堆顶元素，并删除


## 十大排序代码
### 冒泡排序Bubble Sort/插入排序Insertion Sort/选择排序 Selection Sort
```
       public void BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; ++i)
            {
                bool flag = false;
                for (int j = 0; j < arr.Length - 1 - i; ++j)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        arr[j]     = arr[j] ^ arr[j + 1];
                        arr[j + 1] = arr[j] ^ arr[j + 1];
                        arr[j]     = arr[j] ^ arr[j + 1];
                        flag = true;
                    }
                }
                if (!flag) break;
            }
        }
    
        public void InsertionSort(int[] arr){
            for (int i = 1; i < arr.Length; ++i){
                int value = arr[i];
                int j = i - 1;
                while (j >= 0){
                    if (arr[j] > value) arr[j + 1] = arr[j];
                    else break;
                    --j;
                }
                arr[j + 1] = value;
            }
        }

        public void SelectionSort(int[] arr){
            for (int i = 0; i < arr.Length; ++i){
                int minIndex = i;
                for (int j = i + 1; j < arr.Length; ++j){
                    if (arr[j] < arr[minIndex]) minIndex = j;
                }
                arr[i] = arr[i] ^ arr[minIndex];
                arr[minIndex] = arr[i] ^ arr[minIndex];
                arr[i] = arr[i] ^ arr[minIndex];
            }
        }
```


## 特殊排序

### 计数排序 Counting Sort
- 计数排序要求输入的数据必须是有确定范围的整数。将输入的数据值转化为键存储在额外开辟的数组空间中；然后依次把计数大于1的填充回愿数组。

### 桶排序 Bucket Sort
- 建设输入数据服从均匀分布，将数据分到有限数量的桶里，每个桶再分别排序。

### 基数排序 Radix Sort
- 基数排序是按照低位先排序，然后收集；再按照高位排序，然后再收集；依次类推，直到最高位。有时候有些属性是有优先级顺序的，先按照低优先级排序，再按照高优先级排序。