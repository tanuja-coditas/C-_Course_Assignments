
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ClassLibrary3
{
    public class Database<Tkey,Tvalue>
    {
        Tkey[] keys = new Tkey[10];
        Tvalue[] values = new Tvalue[10];
        int _index = 0;

        public int Index {
            get { return _index; } }
        public void Add(Tkey key, Tvalue value)
        {
            if(this.Index == keys.Length)
            {
                Array.Resize(ref keys, 2*keys.Length);
                Array.Resize(ref values, 2*values.Length);
            }
            keys[this.Index] = key;
            values[this.Index] = value;
            _index++;
            Console.WriteLine("pair of key/value has been added to the database");
        }
        public void Remove(Tkey key)
        {
            int index = Array.IndexOf(keys, key);
            if(index != -1)
            {

                for(int i = index;i<keys.Length-1;i++)
                {
                    keys[i] = keys[i + 1];
                    values[i] = values[i + 1];
                }
                Console.WriteLine($"Key/Value removed");
                _index--;
               
            }
            else
            {
                Console.WriteLine("Key is not present");
            }
           
        }

        public bool TryGetValue(Tkey key, out Tvalue value)
        {
            int index = Array.IndexOf(keys, key);
            value = default(Tvalue);
            if (index != -1)
            {
                value = values[index];
                return true;
            }
            else
            {
                Console.WriteLine("Key is not present");
                return false;
            }
        }

        public int Count { get { return _index; } }


    }
}
