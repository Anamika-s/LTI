using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility_Day4
{
    class CountDiv
    {
        static void Main(string[] args)
        {
            int x = solution(6, 11, 2);
            Console.WriteLine(x);
        }

        // you can also use other imports, for example:
        // using System.Collections.Generic;

        // you can write to stdout for debugging purposes, e.g.
        // Console.WriteLine("this is a debug message");

        public static int solution(int A, int B, int K)
        {
            while (A % K != 0)
            {
                ++A;
            }
            while (B % K != 0)
            {
                --B;
            }
            return (B - A) / K + 1;
        }
    }

}
    // write your code in C# 6.0 with .NET 4.5 (Mono)

