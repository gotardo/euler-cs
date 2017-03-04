using System;
using System.Collections.Generic;

namespace projecteuler
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Project Euler");
			foreach(IProblem problem in getProblems()) {
				renderProblemSolution (problem);	
			}
		}

		private static void renderProblemSolution(IProblem problem)
		{
			Console.WriteLine (problem.GetType() + " -\t" + problem.solution ());
			if (!problem.isOk ()) {
				Console.Write ("\tFail !!!!!");
			}
		}

		private static IEnumerable<IProblem>getProblems()
		{
			yield return new Problem1 ();
			yield return new Problem2 ();
		}
	}
}
