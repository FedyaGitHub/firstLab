using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new ForReal().DictMethod();
            Console.ReadLine();
        }
    }
    class MyDictionary<TKey, TValue>
    {
        Dictionary<TKey, TValue> dict = new Dictionary<TKey, TValue>();
        public void Add(TKey arg1, TValue arg2, TKey arg3, TValue arg4)
        {
            dict.Add(arg1, arg2);
            dict.Add(arg3, arg4);
        }

        public int Count { get => dict.Count; }

        public void Method()
        {
            foreach (KeyValuePair<TKey, TValue> keyValuePair in dict)
            {
                Console.WriteLine(keyValuePair.Key + "-" + keyValuePair.Value);
            }
        }
    }
    class ForReal
    {
        public void DictMethod()
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            try
            {
                Console.WriteLine("Enter first key: ");
                int key1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter first value: ");
                string value1 = Console.ReadLine();
                Console.Write("\n");
                Console.WriteLine("Enter second key: ");
                int key2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second value: ");
                string value2 = Console.ReadLine();

                myDictionary.Add(key1, value1, key2, value2);
                Console.Write("\n");
                myDictionary.Method();
                Console.Write("\n");
                Console.WriteLine($"All elements = {myDictionary.Count}");
            }
            catch(Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
        }
    }
}
