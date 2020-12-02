using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility_Day5
{
    class Distinct
    {
        static void Main()
        {
            int[] A = new int[] { };
            int res = solution(A);
            Console.WriteLine(res);
        }

        private static int solution(int[] A)
        {
            A = A.Distinct().ToArray();
            if (A.Length <= 0) return 0;
            else
                return A.Length;

        }
    }

}
