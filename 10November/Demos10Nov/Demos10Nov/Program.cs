using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos10Nov
{
    class Program
    {
        static void Main(string[] args)
        {
            // Give me sum of positive numbers of an array , and exit if number is 0
            int[] num = new int[10];
            int sum = 0;
            Console.WriteLine("Enter Elements");
            for(int i=0;i<10;i++)
            {
                num[i] = Convert.ToSByte(Console.ReadLine());
                if (num[i] == 0) break;
                if (num[i] < 0) continue;
                sum += num[i];

            }
            Console.WriteLine("Sum is " + sum);
            Console.Read();
        }
    }
}
