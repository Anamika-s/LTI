using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility_Day3
{
    class PermCheck
    {

        // you can also use other imports, for example:
        // using System.Collections.Generic;

        // you can write to stdout for debugging purposes, e.g.
        // Console.WriteLine("this is a debug message");
        class Soution
        {
            static void Main()
            {
                int[] A = new int[] { 4, 1, 3 };
                Console.WriteLine(solution(A));

            }

            public static int solution(int[] A)
            {
                
                
                uint
                    expected = (uint)((A.Length + ((A.Length + 1) % 2)) * Math.Ceiling(A.Length / 2.0)),

                    sum = 0;
                Console.WriteLine(Math.Ceiling(A.Length/2.0));
                Console.WriteLine((A.Length +  1) %2);
                Console.WriteLine(expected);
                HashSet<int> digits = new HashSet<int>(A);
                if (digits.Count != A.Length)
                    return 0;
                for (int i = -1; ++i < A.Length; sum += (uint)A[i])
                    ;
                return sum == expected ? 1 : 0;
                // write your code in C# 6.0 with .NET 4.5 (Mono)
            }
        }
    }
}
