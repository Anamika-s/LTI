using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility_Day3
{
    class FrogRiverOne
    {
		static void Main()
		{
			int[] a = new int[]{1,3,1,4,2,3,5,4};
			Console.WriteLine(solution(5, a));
        }
		static public int solution(int X, int[] A)
		{
			bool[] has = new bool[X];
			int count = 0;
			for (var i = -1; ++i < A.Length;)
			{
								if (!has[A[i] - 1])

				{
					has[A[i] - 1] = true;
					if (++count == X)
						return i;
				}
			}
			return -1;

		}		}
	}
