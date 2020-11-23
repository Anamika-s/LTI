using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

namespace Codility_Day2
{
    class Solution1
    {
        public static int solution(int[] A)
        {
            int N = A.Length;
            int[] sum_left = new int[N - 1];
            int[] sum_right = new int[N - 1];
            int[] result = new int[N - 1];

            sum_left[0] = A[0];
            for (int i = 1; i < N - 1; i++)
            {
                sum_left[i] = A[i] + sum_left[i - 1];
            }

            sum_right[0] = A[N - 1];
            for (int i = 1; i < N - 1; i++)
            {
                sum_right[i] = A[N - 1 - i] + sum_right[i - 1];
            }

            for (int i = 0; i < N - 1; i++)
            {
                result[i] = Math.Abs(sum_left[i] - sum_right[N - 2 - i]);
            }

            int min_diff = result.Min();

            return min_diff;
            // write your code in C# 6.0 with .NET 4.5 (Mono)
        }
        
        static void Main()
        {
            int[] A = new int[] { 3, 1, 2, 4, 3 };
            Console.WriteLine(solution(A));
        }
    }
}