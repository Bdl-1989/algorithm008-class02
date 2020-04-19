public class MyCircularDeque {
    public class Deque{
        public Deque pre;
        public Deque next;
        public int val;
        public Deque(int val){
            this.val = val;
        }
    }
    int size;
    int k;
    Deque head;
    Deque tail;
    /** Initialize your data structure here. Set the size of the deque to be k. */
    public MyCircularDeque(int k) {
        head = new Deque(-1);
        tail = new Deque(-1);
        head.pre = tail;
        tail.next = head;
        this.k = k;
        this.size = 0;
    }
    
    /** Adds an item at the front of Deque. Return true if the operation is successful. */
    public bool InsertFront(int value) {
        if (size == k){
            return false;
        }
        Deque node = new Deque(value);
        node.next = head;
        node.pre = head.pre;
        head.pre.next = node;
        head.pre = node;
        size++;
        return true;
    }
    
    /** Adds an item at the rear of Deque. Return true if the operation is successful. */
    public bool InsertLast(int value) {
        if (size == k){
            return false;
        }
        Deque node = new Deque(value);
        node.next = tail.next;
        tail.next.pre = node;
        tail.next = node;
        node.pre = tail;
        size++;
        return true;
    }
    
    /** Deletes an item from the front of Deque. Return true if the operation is successful. */
    public bool DeleteFront() {
        if (size == 0){
            return false;
        }
        head.pre.pre.next = head;
        head.pre = head.pre.pre;
        size--;
        return true;
    }
    
    /** Deletes an item from the rear of Deque. Return true if the operation is successful. */
    public bool DeleteLast() {
        if (size == 0){
            return false;
        }
        tail.next.next.pre = tail;
        tail.next = tail.next.next;
        size--;
        return true;
    }
    
    /** Get the front item from the deque. */
    public int GetFront() {
        return head.pre.val;
    }
    
    /** Get the last item from the deque. */
    public int GetRear() {
        return tail.next.val;
    }
    
    /** Checks whether the circular deque is empty or not. */
    public bool IsEmpty() {
        return size == 0;
    }
    
    /** Checks whether the circular deque is full or not. */
    public bool IsFull() {
        return size == k;
    }
}

/**
 * Your MyCircularDeque object will be instantiated and called as such:
 * MyCircularDeque obj = new MyCircularDeque(k);
 * bool param_1 = obj.InsertFront(value);
 * bool param_2 = obj.InsertLast(value);
 * bool param_3 = obj.DeleteFront();
 * bool param_4 = obj.DeleteLast();
 * int param_5 = obj.GetFront();
 * int param_6 = obj.GetRear();
 * bool param_7 = obj.IsEmpty();
 * bool param_8 = obj.IsFull();
 */