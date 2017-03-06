using System.Collections.Generic;

namespace Matematica.Sequence.Fibo
{
	public interface ISequence
	{
		IEnumerable<int> GetSequence (int limit);
	}
}
