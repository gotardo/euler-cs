using System.Collections.Generic;
using Matematica.Sequence;
using Matematica.Sequence.Fibo;

namespace Projecteuler.Problem
{
	// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these
	// multiples is 23.Find the sum of all the multiples of 3 or 5 below 1000.
	// https://projecteuler.net/problem=1
	public class Problem2: IProblem
	{
		public int Solution()
		{
			int solution = 0;
			IEnumerable<int> Sequence = (new Fibo()).GetSequence (4000000);
			foreach (int number in Sequence) {
				if (0 == number % 2) {
					solution += number;
				}
			}
			return solution;
		}

		public bool IsOk()
		{
			return Solution () == 4613732;
		}
	}
}
