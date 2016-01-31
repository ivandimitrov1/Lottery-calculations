using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryData
{
	public class CombinationResult : RegisterResult
	{
		private HashSet<int> combination;

		public CombinationResult()
		{
			this.combination = new HashSet<int>();
		}

		public HashSet<int> Combination
		{
			get
			{
				return combination;
			}
			set
			{
				this.combination = value;
			}
		}
	}
}
