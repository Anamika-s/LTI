using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility_Day4
{
    class PassingCars
    {
        static void Main()
        {
            int[] A = new int[] { 0,1,0,1,1 };
            int x = solution(A);
            Console.WriteLine(x);
        }
        static int solution(int[] A)
        {
            int l = A.Length;
            int countZero = 0;
            int countPairs = 0;
            int exceed = 1000000000;


            for (int i = 0; i < l; i++)
            {
                if (A[i] == 1) countPairs += countZero;
                else countZero++;

            }

            if (countPairs > exceed || countPairs < 0) return -1;
            else return countPairs;

        }
        // write your code in C# 6.0 with .NET 4.5 (Mono)

    }
}