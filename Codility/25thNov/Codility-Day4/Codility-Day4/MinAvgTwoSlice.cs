using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility_Day4
{
    class MinAvgTwoSlice
    {
        static void Main()
        {
            int[] A = new int[]{4,2,2,5,1,5,8};
            int x = solution(A);
        }
        public static int solution(int[] A)
        {
            int minI = 0;
            double minValue = 100001.0;

            for (int i = 0; i < A.Length - 1; i++)
            {

                if (((A[i] + A[i + 1]) / 2.0) < minValue)
                {
                    minI = i;
                    minValue = (A[i] + A[i + 1]) / 2.0;

                }
                if (i < A.Length - 2)
                {
                    if (((A[i] + A[i + 1] + A[i + 2]) / 3.0) < minValue)
                    {
                        minI = i;
                        minValue = (A[i] + A[i + 1] + A[i + 2]) / 3.0;
                    }
                }
            }

            return minI;
            // write your code in C# 6.0 with .NET 4.5 (Mono)
        }
    }
}