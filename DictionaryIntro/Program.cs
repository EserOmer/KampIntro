using System;


namespace DictionaryIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<double, string> myDictionary = new MyDictionary<double, string>();
            Console.WriteLine(myDictionary.count);
            myDictionary.Add(12.2,"Omer");
            myDictionary.Add(13.4, "Eser");
            Console.WriteLine(myDictionary.count);
            for (int i = 0; i < myDictionary.count; i++)
            {
                Console.WriteLine(i+". Key= "+ myDictionary.Keys[i]);
            }
            for (int i = 0; i < myDictionary.count; i++)
            {
                Console.WriteLine(i + ". Values= " + myDictionary.Values[i]);
            }
        }
    }

    class MyDictionary<TK,TV>
    {
        TK[] keys;
        TV[] values;
        public MyDictionary()
        {
            keys= new TK[0];
            values= new TV[0];
        }
        public void Add(TK key,TV value)
        {
            TK[] tmpKeys = keys;
            TV[] tmpValues = values;
            keys = new TK[keys.Length+1];
            values = new TV[values.Length+1];
            for (int i = 0; i < tmpKeys.Length; i++)
            {
                keys[i] = tmpKeys[i];
                values[i] = tmpValues[i];
            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }
        public int count
        {
            get { return keys.Length; }
        }
        public TK[] Keys {get { return keys; } }
        public TV[] Values {get { return values; } }
        
    }
}
