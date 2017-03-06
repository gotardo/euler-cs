using System.Collections.Generic;

namespace Matematica.Sequence.Fibo
{
	public class Fibo : IFibo
	{
		public IEnumerable<int> GetSequence(int limit)
		{
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
	}
}
