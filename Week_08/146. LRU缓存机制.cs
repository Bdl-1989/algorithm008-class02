//https://leetcode-cn.com/problems/lru-cache/#/


public class LRUCache {
    //链表节点类
    public class DLinkNode{
        public int key;
        public int value;
        public DLinkNode prev;
        public DLinkNode next;
        public DLinkNode(){}
        public DLinkNode(int key, int value){
            this.key = key;
            this.value = value;
        }
    }
    //缓存映射表
    private Dictionary<int, DLinkNode> cache = new Dictionary<int, DLinkNode>();
    //缓存大小
    private int size;
    //缓存容量
    private int capacity;
    //链表头部和尾部
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
    //获取节点
    public int Get(int key) {
        DLinkNode node = new DLinkNode();
        if (!cache.TryGetValue(key, out node)) return -1;
        //移动到链表头部
        moveToHead(node);
        return node.value;
    }
    //添加节点
    public void Put(int key, int value) {
        DLinkNode node = new DLinkNode();
        if (!cache.TryGetValue(key, out node)){
            DLinkNode newNode = new DLinkNode(key, value);
            cache.Add(key, newNode);
            //添加到链表头部
            addToHead(newNode);
            ++size;
            //如果缓存已满，需要清理尾部节点
            if (size > capacity){
                DLinkNode tail = removeTail();
                cache.Remove(tail.key);
                --size;
            }
        }else{
            node.value = value;
            //移动到链表头部
            moveToHead(node);
        }
    }
    //删除尾节点
    private DLinkNode removeTail(){
        DLinkNode node = tail.prev;
        removeNode(node);
        return node;
    }
    //删除节点
    private void removeNode(DLinkNode node){
        node.next.prev = node.prev;
        node.prev.next = node.next;
    }

    private void addToHead(DLinkNode node){
        node.prev = head;
        node.next = head.next;
        head.next.prev = node;
        head.next = node;
    }

    private void moveToHead(DLinkNode node){
        removeNode(node);
        addToHead(node);
    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */