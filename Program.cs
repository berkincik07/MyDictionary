using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> sozluk1 = new Dictionary<int, string>();
            sozluk1.Add(3, "Ali");
            Console.WriteLine(sozluk1.Values);
            MyDictionary<int, string> sozluk2 = new MyDictionary<int, string>();
            sozluk2.Add(5, "Berk");
        }
    }

    class MyDictionary<Tkey, Tvalue>
    {
        Tkey[] keys;
        Tvalue[] values;

        public MyDictionary()
        {
            keys = new Tkey[0];
            values = new Tvalue[0];
        }

        public void Add(Tkey key, Tvalue value)
        {
            Tkey[] tempKeys = keys;
            Tvalue[] tempValues = values;

            keys = new Tkey[keys.Length + 1];
            values = new Tvalue[values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
                values[i] = tempValues[i];
            }

            for (int i = 0; i < tempKeys.Length; i++)
            {
                if (key == null)
                {
                    throw new ArgumentNullException("Key cannot be null.");
                }
                else if (tempKeys[i].Equals(key)) 
                {
                    throw new ArgumentException("An element with the same key already exists in key array");
                }
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        
        }
    }
}
