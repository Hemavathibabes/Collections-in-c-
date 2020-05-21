using System;
using System.Collections;

namespace Collections
{
   

    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList


            ArrayList al = new ArrayList();
            int a = 101;
            al.Add(a);
            al.Add("This is a arraylist");
            al.Add(2.3f);
            al.Insert(3, "This is the forth index");
          
            ArrayList al2 = new ArrayList();
            al2.Add(102);
            al.InsertRange(1, al2);
            Console.WriteLine("ArrayList:");
                Console.WriteLine();
            foreach(var ele in al)
            {
                Console.WriteLine(ele + " ");
            }
            Console.WriteLine("The count of the arraylist is {0}", al.Count);
            Console.WriteLine("The capacity of the arraylist is {0}", al.Capacity);
            Console.WriteLine();
            // Hash table

            Hashtable ht = new Hashtable();
            ht.Add(1, "one");
            ht.Add(2, "two");
            ht.Add(0.3f, 2);
            ht.Add(4, null);
            ht.Add("Hema", "vathi");
            ht.Remove(2);
           // ht.Clear();
            Console.WriteLine("Hashtable:");
            Console.WriteLine();
            foreach (DictionaryEntry ele in ht)   //ht.keys means only print a key values for values the viceversa is applied.
            {
                Console.WriteLine("{0},{1}", ele.Key, ele.Value);
                
            }
            String firstelement =(string)ht[1];
            String str = (string)ht["Hema"];
            Console.WriteLine("The first element in the hashtable is {0}",firstelement);
            Console.WriteLine("The last element in the hashtable is {0}", str);
            Console.WriteLine("The hash table contains a 0.3  is {0}", ht.Contains(0.3f));
            Console.WriteLine();

            //SortedList
            Console.WriteLine("Sorted List:");
            SortedList sl = new SortedList();
            sl.Add(2, "two");
            sl.Add(1, "one");
            sl.Add(0, "zero");
           sl.RemoveAt(0);
            foreach(DictionaryEntry i in sl)
            {
                Console.WriteLine("{0},{1}",i.Key,i.Value);
            }
            Console.WriteLine();

            //stack

            Console.WriteLine("Stack:");
            Stack s = new Stack();
            s.Push("hello");
            s.Push(102);
            s.Push(102);
            s.Push(.3f);
            foreach(var item in s)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("The first element will be deleted is {0} ",s.Peek());
            Console.WriteLine();

            //Queue

            Console.WriteLine("Queue:");
            Queue q = new Queue();

            q.Enqueue(34);
            q.Enqueue("thirtyfour");
            q.Enqueue(3.4);
            q.Dequeue();
            foreach(var item in q)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("The first element of the queue is {0}", q.Peek());
        }
    }
}
