using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<Key,Value>
    { 
        Key[] keys;
        Value[] values;
        
        public MyDictionary()
        {
            keys = new Key[0];
            values = new Value[0];
        }

        public void Add(Key key, Value value)
        {
            Key[] tempKeys = keys;
            Value[] tempValue = values;
            keys = new Key[keys.Length + 1];
            values = new Value[values.Length+1];

            //Key yoksa value'nunda bir anlamı kalmadığından key kadar döndürdüm.
            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
                values[i] = tempValue[i];
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;

            Console.WriteLine("İstediğiniz Ülke: "+key+". Ülkeye ait Ülke Kodu: "+value);

        }
    }
}
