using System;
using System.Collections.Generic;
using System.Text;

namespace LRUCache
{
    class KeyValuePair<TKey, TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }
        public KeyValuePair(TKey key, TValue val)
        {
            Key = key;
            Value = val;
        }
    }
}
