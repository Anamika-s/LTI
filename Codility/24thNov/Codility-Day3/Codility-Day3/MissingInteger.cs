using System;
using System.Collections.Generic;
using System.Linq;

namespace Codility_Day3
{
    class MissingInteger
    {
		static void Main()
        {
			int[] A = new int[] { 1, 3, 6, 4, 1, 2 };
            Console.WriteLine(solution(A));

        }
		public static int solution(int[] A)
		{
			int[] a = new int[10];
			a.Contains(2);

			int min = 1;
		HashSet<int> numbers = new HashSet<int>();
			foreach (int n in A) {
				if (!numbers.Contains(n)) {
					numbers.Add(n);
					if (n == min)
						while (numbers.Contains(++min));
				}
}
			return min;


}    }
}
