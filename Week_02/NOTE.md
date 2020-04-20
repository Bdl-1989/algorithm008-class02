学习笔记
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