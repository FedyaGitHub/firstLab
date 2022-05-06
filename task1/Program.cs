using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new ForRealization().ReturnMethod();
            Console.ReadLine();
        }
    }
    class MyList<T>
    {
        public List<T> someList;
        
        public MyList() => someList = new List<T>();
        public void AddMethod(T [] arratList)
        {
            Console.WriteLine("Adding elements..");
            someList.AddRange(arratList);
            
        }
        public void DeleteMethod()
        {
            Console.WriteLine("Enter index to remove: ");
            int argument = Convert.ToInt32(Console.ReadLine());
            someList.RemoveAt(argument);
            Console.Write("\n");
        }
        public void OutputMethod()
        {
            Console.WriteLine("List output: ");
            foreach (var item in someList)
            {
                Console.Write("\n");
                Console.Write(item);
            }
        }
        public int Count => someList.Count;

        public T this[int index] => someList[index];
        
    }
    class ForRealization
    {
        public void ReturnMethod()
        {
          
            int[] arrayList = new int[7] { 9, 4, -7, 2, 5, 10,3 };
            MyList<int> myList = new MyList<int>();
            myList.AddMethod(arrayList);
            myList.DeleteMethod();
            myList.OutputMethod();

            Console.Write("\n");
            Console.WriteLine($"All elements in list = {myList.Count}");
            Console.Write("\n");
            Console.WriteLine("Enter index: ");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.Write($"This is {myList[index]}");

        }
    }
}
