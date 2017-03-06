using System;

namespace Projecteuler.Problem
{
	public interface IProblem
	{
		int Solution();
		bool IsOk();
	}
}
