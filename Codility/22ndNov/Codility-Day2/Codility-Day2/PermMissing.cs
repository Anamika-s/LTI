using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility_Day2
{
    class PermMissing
    {
        public static int solution(int[] A)
        {

            int N = A.Length + 1;

            int sum1 = 0;
            int sum2 = 0;
            for (int i = 1; i < N; i++)
            {
                sum1 += A[i - 1];
                sum2 += i;
            }
            sum2 += N;

            int missing = sum2 - sum1;

            return missing;
        }
        static void Main()
        {
            int[]A = new int[] {1, 3, 5, 4, 6};
            Console.WriteLine(solution(A));
        }
    }
}