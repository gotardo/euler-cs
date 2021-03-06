﻿using System.Collections.Generic;

namespace Projecteuler.Problem
{
	/**
	 * 	If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these
     *	multiples is 23.Find the sum of all the multiples of 3 or 5 below 1000.
     *
     *	https://projecteuler.net/problem=1
	 */
	public class Problem1: IProblem
	{
		public int Solution()
		{
			int solution = 0;
			IEnumerable<int> sequence = NumberSequence ();
			foreach (int number in sequence) 
			{
				solution += number;
			}


			return solution;
		}

		private IEnumerable<int> NumberSequence(){
			for (int i = 0; i < 1000; i++) {
				if (0 == i % 3 || 0 == i % 5) {
					yield return i;
				}
			}
		}

		public bool IsOk()
		{
			return Solution () == 233168;
		}
	}
}
