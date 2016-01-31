using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combinatorics
{
	public class Combinatoric
	{
		// n is the number of all elements 
		// k is the count of elements of the combination
		public static ulong GetCombinationsWithNoRepetitions(int n, int k)
		{
			if (n < k)
			{
				return 0;
			}
			else if (n == k)
			{
				return 1;
			}
			else
			{
				// formula for number of combinations
				//       n!
				//	C = ____
				//		k!(n-k)!

				var nFactoriel = Combinatoric.Factoriel(n, k);
				var kFactoriel = Combinatoric.Factoriel(k, k);

				var combinationsCount = nFactoriel / kFactoriel;
				return combinationsCount;
			}
		}

		public static ulong Factoriel(int n, int k)
		{
			ulong sum = 1;
			ulong ulongElementsCount = Convert.ToUInt64(n);
			for (int i = 0; i < k; i++, ulongElementsCount--)
			{
				sum *= ulongElementsCount;
			}
			return sum;
		}
	}
}
