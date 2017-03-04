using System;
using System.Collections.Generic;

namespace projecteuler
{
	// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these
	// multiples is 23.Find the sum of all the multiples of 3 or 5 below 1000.
	// https://projecteuler.net/problem=1
	public class Problem2: IProblem
	{
		public int solution()
		{
			int solution = 0;
			IEnumerable<int> sequence = fibo (4000000);
			foreach (int number in sequence) {
				if (0 == number % 2) {
					solution += number;
				}
			}


			return solution;
		}

		private IEnumerable<int> fibo(int limit){
			int x = 0;
			int a = 1; 
			int b = 2;
		
			yield return a;
			yield return b;
			while (b <= limit) {
				x = a;
				a = b;
				b = x + b;
				yield return b;
			}
		}

		public bool isOk()
		{
			return solution () == 4613732;
		}
	}
}
