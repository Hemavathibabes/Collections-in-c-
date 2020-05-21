using System;
using System.Collections.Generic;
using System.Linq;

namespace Generic_Collections
{

    internal class student
    {
        public int Id { get; set; }
        public string name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List:");
            List<int> intlist = new List<int>();
            intlist.Add(12);
            intlist.Add(34);
            intlist.Add(56);
            Console.WriteLine("Integer list");
            foreach (int i in intlist)
            {
                Console.WriteLine(i);
            }

            List<string> strlist = new List<string>()
            { "It" , "is" ,"a" ,"string" , "list" };
            Console.WriteLine("String List");
            foreach (String st in strlist)
            {
                Console.WriteLine(st);
            }

            Console.WriteLine("object string");
            List<student> obj = new List<student>()
            {
                new student() { Id = 101, name = "Karthik" },
                new student() { Id = 102, name = "jessi" }

            };
            foreach (var item in obj)
            {
                Console.WriteLine("{0},{1}", item.Id, item.name);
            }

            Console.WriteLine();


            //Dictionary
            Console.WriteLine("Dictionary");
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "first");
            dic.Add(2, "second");
            dic.Add(3, "third");


            foreach (var d in dic)
            {
                Console.WriteLine("{0},{1}", d.Key, d.Value);
            }

            Console.WriteLine("the first key value pair is {0},{1}", dic.ElementAt(0).Key, dic.ElementAt(0).Value);
            Console.WriteLine();
            IDictionary<int, student> odic = new Dictionary<int, student>()
            {
                { 1, new student() { Id = 301, name = "Varun" } },
                { 2,new student() { Id = 302, name = "Nithya" } }
            };

            foreach (var od in odic)
            {
                Console.WriteLine("{0},{1},{2}", od.Key, od.Value.Id, od.Value.name);
            }
            Console.WriteLine();

            //sorted list
            Console.WriteLine("Sorted List:");
            SortedList<int, string> sl = new SortedList<int, string>();
            sl.Add(1, "India");
            sl.Add(2, "America");
            sl.Add(3, "china");

            foreach (var i in sl)
            {
                Console.WriteLine("{0},{1}", i.Key, i.Value);
            }
            Console.WriteLine("the value for 1st key is {0}", sl[1]);
            Console.WriteLine();


            //stack


            Console.WriteLine("Stack:");
            Stack<string> s = new Stack<string>();
            s.Push("this is");
            s.Push("generic");
            s.Push("stack");
            s.Pop();
           foreach(String str in s)
            {
                Console.WriteLine(str + " ");
            }
            Console.WriteLine();

            //Queue
            Console.WriteLine("Queue:");
            Queue<float> fl = new Queue<float>();
            fl.Enqueue(0.3f);
            fl.Enqueue(.5f);
            fl.Enqueue(.2f);
            fl.Dequeue();
            foreach (float f in fl)
            {
                Console.WriteLine(f + " ");
            }
            
        }

    }
}

   