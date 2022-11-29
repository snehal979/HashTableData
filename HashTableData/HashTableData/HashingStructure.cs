using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableData
{
    public class HashingStructure< K, V>
    {

        private readonly int size;
        private readonly LinkedList<KeyValue<K, V>>[] items;


        public HashingStructure(int size)
        {
            this.size =size;
            this.items = new LinkedList<KeyValue<K, V>>[size];
        }
        public int GetArrayPosition(K key)
        {
            int position = key.GetHashCode()%size;
            return Math.Abs(position);
        }
        public V Get(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedlist = GetLinkedList(position);
            foreach (KeyValue<K, V> item in linkedlist)
            {
                if (item.Key.Equals(key))
                {
                    return item.Value;
                }
            }
            return default(V);
        }
        // add
        public void Add(K Key, V value)
        {
            int position = GetArrayPosition(Key);
            LinkedList<KeyValue<K, V>> linkedlist = GetLinkedList(position);
            KeyValue<K, V> item = new KeyValue<K, V>() { Key = Key, Value = value };
            linkedlist.AddLast(item);
        }
        public void Remove(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedlist = GetLinkedList(position);
            bool itemFound = false;
            KeyValue<K, V> fonditem = default(KeyValue<K, V>);
            foreach (KeyValue<K, V> item in linkedlist)
            {
                if (item.Key.Equals(key))
                {
                    itemFound = true;
                    fonditem = item;
                }
            }
            if (itemFound)
            {
                linkedlist.Remove(fonditem);
                Console.WriteLine("remove that data");
            }
        }
        protected LinkedList<KeyValue<K, V>> GetLinkedList(int position)
        {
            LinkedList<KeyValue<K, V>> linkedlist = items[position];
            if (linkedlist ==null)
            {
                linkedlist = new LinkedList<KeyValue<K, V>>();
                items[position] = linkedlist;
            }
            return linkedlist;
        }
        public struct KeyValue<K, V>
        {
            public K Key { get; set; }
            public V Value { get; set; }
        }



    }
}
