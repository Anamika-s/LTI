using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility_Day5
{
    class MaxProductOfThree
    {
        static void Main(string[] args)
        {
             int[] A = new int[] {-3,1,2,-2,5,6 };
            int res = solution(A);
            Console.WriteLine(res);
        }
        public static int solution(int[] A)
        {
            int result1 = 0, result2 = 0, result = 0, length = A.Length;
            Array.Sort(A);
            if (length >= 3)
            {
                result1 = A[length - 1] * A[length - 2] * A[length - 3];
                result2 = A[0] * A[1] * A[length - 1];
                if (result1 > result2)
                    result = result1;
                else
                    result = result2;
            }

            return result;

            // write your code in C# 6.0 with .NET 4.5 (Mono)
        }
    }

}

