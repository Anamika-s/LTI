using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility_Day2
{
    class CyclicRotation
    {
        static void Main()
        {
            int[] A = new int[] { 3, 8, 9, 7, 6 };
            int K = 3;
            int[] resultArray = solution(A, K);
            foreach (int temp in resultArray)
                Console.WriteLine(temp) ;
        }

        private static int[] solution(int[] A, int K)
        {
            var B = new int[A.Length];
            for(int i=0;i<A.Length;i++)
            {
                B[(i + K) % A.Length] = A[i];

            }
            return B;
        }
    }
}
