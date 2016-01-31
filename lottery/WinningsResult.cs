using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryData
{
	public class WinningsResult : RegisterResult
	{
		// storage for number of profitable combinations for six numbers, fives, fours to zero ..
		private ulong[] winnigs;

		public WinningsResult()
		{
			// default values are zeroes
			winnigs = new ulong[DefaultValues.JACKPOT_NUMBERS_COUNT];
		}

		public ulong[] Winnings
		{
			get
			{
				return this.winnigs;
			}
			set
			{
				this.winnigs = value;
			}
		}
	}
}
