using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos10Nov
{
    class Collections
    {
        static void Main()
        {
            Console.WriteLine("ArrayList");
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);   // Boxing
            list.Add(5);
            list.Add("AAAA");
            list.Add(20.9);
            //for(int i=0;i<list.Count;i++)
            //    Console.WriteLine(list[i]);

            foreach (var temp in list)
                Console.WriteLine(temp);
            list.Insert(1, 10);
            list.RemoveAt(2);
            list.Remove(5);


            Console.WriteLine("Stack");
            // Stack LIFO
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Pop();
            foreach(int temp in stack)
                Console.WriteLine(temp);
            Console.WriteLine("Queue");
            // Queue FIFO
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Dequeue();

            foreach (int temp in queue)
                Console.WriteLine(temp);

            Console.WriteLine("HashTable");
            // Hashtable
            // Random Searching
            //Elements are stored as Key and Value Pair
            Hashtable ht = new Hashtable();
            ht["ajay"] = 20;
            ht[2] = 30;
            ht[3] = 89;

            foreach(var temp in ht.Keys)
            {
                Console.WriteLine(temp);
            }

            Console.WriteLine("The Keys are");
          
            foreach(int key in ht.Keys)
                Console.WriteLine(key + " " + ht[key]);

            Console.Read();
            Console.WriteLine(ht[3]);

             foreach (var temp in list)
                Console.WriteLine(temp);
            //for (int i = 0; i < list.Count; i++)
            //    Console.WriteLine(list[i]);

            list.Add("AAAA");
            list.Add(20.9);

        }
    }
}
