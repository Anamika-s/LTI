using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility_Day2
{
    class BinaryGap2
    {
        static void Main()
        {
            Console.WriteLine(solution(1041));
        }
        static int solution(int N)
        { 
        int longestBinaryGap = 0;
        int currentBinaryGap = -1;

        int val = N;
            Console.WriteLine(Convert.ToString(N, toBase: 2));

            while (val != 0) {
        if ((val & 1) == 1) {
            if (longestBinaryGap<currentBinaryGap) {
                longestBinaryGap = currentBinaryGap;
            }

    currentBinaryGap = 0;
        } else if (currentBinaryGap != -1) {
            ++currentBinaryGap;
        }
        
            val = val >> 1;
    }
    
    return longestBinaryGap;
    }
    }
}
