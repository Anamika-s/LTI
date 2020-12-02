using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility_Day5
{
    class Triangle
    {
        static void Main()
        {
            int[] A = new int[] { Int32.MaxValue, Int32.MaxValue, 2, 2, Int32.MaxValue, Int32.MaxValue, Int32.MaxValue };
            int res = solution(A);
            Console.WriteLine(res);
        }
        public static int solution(int[] A)
        {
            long p, q, r;
            if (A.Length > 2)
            {
                Array.Sort(A);
                for (var i = 0; i < A.Length - 2; i++)
                {
                    p = A[i];
                    q = A[i + 1];
                    r = A[i + 2];
                    if (p + q > r)
                        return 1;
                }
            }
            return 0;
        }
    }
}
