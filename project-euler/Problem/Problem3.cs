using System;
using System.Collections.Generic;
using System.Linq;

namespace Projecteuler.Problem
{
	/**
	 * 	Pendiente de hacer una refactorización para que factor sólo tome el valor de números primos.
	 */
	public class Problem3: IProblem
	{
		public int Solution ()
		{
			long num = 600851475143;
			int factor = 1;
			int highestFactor = 1;

			while (num > 1) {
				if (0 == num % factor) {
					num = num / factor;
					highestFactor = factor;
					factor = 1;
				}
				factor += 1;
			}
			return highestFactor;
		}

		public bool IsOk()
		{
			return Solution() == 6857;
		}
	}
}
