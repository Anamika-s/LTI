using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility_Day3
{
    class MaxCounter
    {
        static void Main(string[] args)
        {
			int[] A = new int[] { 3, 4, 4, 6, 1, 4, 4 };
            Console.WriteLine(solution(5, A));
        }
 			static int[] solution(int N, int[] A)
			{
				var counters = new int[N];
				int max = 0, min = 0;
				foreach (var n in A)
					if (n == N + 1)
						min = max;
					else
					{
						var v = counters[n - 1];
						if ((counters[n - 1] = Math.Max(v, min) + 1) > max)
							max = counters[n - 1];
					}
				for (int i = counters.Length; --i >= 0;)
					if (counters[i] < min)
						counters[i] = min;
				return counters;


				// write your code in C# 6.0 with .NET 4.5 (Mono)
			}
		

	}
}
