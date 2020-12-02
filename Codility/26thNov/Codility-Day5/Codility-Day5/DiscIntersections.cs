using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility_Day5
{
	public class Comparer : IComparer
	{
		public int Compare(object x, object y)
		{
			Circle a = (Circle)x;
			Circle b = (Circle)y;
			int X;
			if (a.left.CompareTo(b.left) == 0)
			{
				X = a.position.CompareTo(b.position);
				return X;

			}
			else
			{
				X = a.left.CompareTo(b.left);
				return X;
			}
		}
	}
	class Circle
	{
		public long radius;
		public long position;
		public long left
		{
			get
			{
				return position - radius;
			}
		}
		public long right
		{
			get
			{
				return position + radius;
			}
		}
	}

	class DiscIntersections
    {
 static void Main()
        {
			int[] A = new int[] { 1, 5, 2, 1, 4, 0 };
			int res = solution(A);
            Console.WriteLine(res);
        }
		
		public static int solution(int[] A)
		{
			int count = 0;
			var circles = new Circle[A.Length];
			for (var i = -1; ++i < A.Length;)
			{
				circles[i] = new Circle
				{
					radius = A[i],
					position = i
				};
			}
			var list = new List<Circle>();
			Array.Sort(circles, new Comparer());
            Console.WriteLine(list.Count);
			for (var i = -1; 
				++i < circles.Length;)
			{
				for (var j = list.Count; --j >= 0;)
				{
					if (list[j].right < circles[i].left)
						list.RemoveAt(j);
				}
				if ((count += list.Count) > 1e7)
					return -1;
				list.Add(circles[i]);
			}
			return count;
		}
	}

}

