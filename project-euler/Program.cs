using System;
using System.Collections.Generic;
using Projecteuler.Problem;

namespace Projecteuler
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Project Euler");
			foreach(IProblem problem in GetProblems()) {
				RenderProblemSolution (problem);	
			}
			Console.WriteLine ("-- end");
		}

		private static void RenderProblemSolution(IProblem problem)
		{
			Console.WriteLine (problem.GetType() + " -\t" + problem.Solution ());
			if (!problem.IsOk ()) {
				Console.Write ("\tFail !!!!!");
			}
		}

		private static IEnumerable<IProblem>GetProblems()
		{
			yield return new Problem1 ();
			yield return new Problem2 ();
			yield return new Problem3 ();
		}
	}
}
