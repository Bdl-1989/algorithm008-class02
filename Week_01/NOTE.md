学习笔记
## 数组、链表、跳表的基本实现和特性
### Array
- 时间复杂度：insert和delete都是O(n)，其余都是O(1)
### Linked List
- 内含一个类/值一个next
- 含一个next指针是单链表
- 此外含pre和next叫做双向链表
- 链表的头叫head，尾叫tail
- 如果tail的next指向head就是循环链表
- 时间复杂度：lookup为O(n)，其余为O(1)
- 应用：LRU cash
### skip list
- 时间复杂度：lookup, delete and insert 为 O(log(n))
- 对标的是平衡树和二分查找
- 有序的
- 升维/空间换时间
- redis

### 4/13
- go: append

### 4/15
- C#: Array.Reverse(array)
- C#: Array.Reverse(array, index, length)
- C#/Java:
  ```
    public static void swap(int[] arr, int a , int b)
    {
        arr[a] = arr[a] ^ arr[b];
        arr[b] = arr[a] ^ arr[b];
        arr[a] = arr[a] ^ arr[b]
    } 
    //使用异或置换，以后再也不用tmp
  ```
- go: 
> - slice的默认开始位置是0，ar[:n]等价于ar[0:n]
> - slice的第二个序列默认是数组的长度，ar[n:]等价于ar[n:len(ar)]
> - 如果从一个数组里面直接获取slice，可以这样ar[:]，因为默认第一个序列是0，第二个是数组的长度，即等价于ar[0:len(ar)]
### 4/16
超哥分享
>- raw productivity
>- proactive
>- prioritize tasks - impact / urgency
>- consumer -> producer
>- empathy
>- https://zhuanlan.zhihu.com/prattle

- java/c#: 字符串转int：50'2'-'0'