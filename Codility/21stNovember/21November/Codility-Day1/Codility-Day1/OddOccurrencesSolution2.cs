using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

public class Program
{
	private const int PAIR_MAX = 1000000000;

	public static void Main()
	{
		// Generate test data
		var data = new List<int>();
		var rnd = new Random();
		for (var i = 0; i < 50000; i++)
		{
			data.Add(rnd.Next(1, 100000));
		}

		// RUN SUBMITTED SOLUTION
		var stopwatch1 = Stopwatch.StartNew();
		var result1 = solution(data.ToArray());
		stopwatch1.Stop();

		// RUN SOLUTION THOUGHT OF AFTER SUBMISSION :(
		var stopwatch2 = Stopwatch.StartNew();
		var result2 = solution_performant(data.ToArray());
		stopwatch2.Stop();

		// Print result and time from submitted solution
		Console.WriteLine("Submitted solution:");
		Console.WriteLine(string.Format("Result:   {0}", result1));
		Console.WriteLine(string.Format("Elapsed:  {0}", stopwatch1.ElapsedMilliseconds));
		Console.WriteLine();

		// Print result and time from revised solution
		Console.WriteLine("Revised solution:");
		Console.WriteLine(string.Format("Result:   {0}", result2));
		Console.WriteLine(string.Format("Elapsed:  {0}     <--- significantly faster  :(", stopwatch2.ElapsedMilliseconds));
	}

	public static int solution(int[] A)
	{
		// Running count of matched pairs
		var pairs = 0;

		// Iterate through items (as i)
		for (int i = 0; i < A.Length; i++)
		{
			// Iterate through items (as j)
			// Looking for pairs with a greater index so start from i + 1
			for (int j = i + 1; j < A.Length; j++)
			{
				// If match found
				if (A[i] == A[j])
				{
					// Increment count
					pairs++;

					if (pairs == PAIR_MAX)
					{
						// Reached limit of 1M - return
						return pairs;
					}
				}
			}
		}

		return pairs;
	}

	public static int solution_performant(int[] A)
	{
		int pairs = 0;
		var indexes = new Dictionary<int, List<int>>();

		// Iterate through items
		for (int i = 0; i < A.Length; i++)
		{
			var val = A[i];

			if (!indexes.ContainsKey(val))
			{
				// Add empty list for this value
				indexes.Add(A[i], new List<int>());
			}

			// Add current index against this value
			indexes[val].Add(i);
		}

		// Iterate through indexes grouped by value
		foreach (var ix in indexes)
		{
			if (ix.Value.Count <= 1)
				continue;

			// Calculate number of pairs where index is greater
			pairs += Enumerable.Range(1, ix.Value.Count - 1).Sum();

			if (pairs >= PAIR_MAX)
			{
				// Reached limit of 1M - return
				return PAIR_MAX;
			}
		}

		return pairs;
	}
}