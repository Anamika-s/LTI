using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos10Nov
{
    class GenericCollectionDemo
    {
        public static void Main()
        {
            // ArrayList
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            // There is no boxing // unboxing
            foreach(int temp in list)
                Console.WriteLine(temp);

            Stack<string> stack = new Stack<string>();
            stack.Push("jay");
            stack.Push("lalit");
            stack.Push("JAtin");
            stack.Pop();

            foreach (string temp in stack)
                Console.WriteLine(temp);

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);

            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict["Ajay"] = 90;
            dict["Deepak"] = 89;

            
        }
    }
}
