using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Combinatorics;

namespace LotteryData
{
	public class Lottery
	{
		private HashSet<int> jackpot;

		private HashSet<int> checkTalon;

		private CombinationResult RegisterCombination(string combination)
		{
			// keeps errors from wrong combination string
			CombinationResult result = new CombinationResult();

			var splittedCombination = combination.Split(',');

			foreach (var numb in splittedCombination)
			{
				int number;
				if (int.TryParse(numb, out number))
				{
					if (number >= DefaultValues.START_RANGE_OF_COMBINATION &&
												number <= DefaultValues.END_RANGE_OF_COMBINATION)
					{
						if (result.Combination.Contains(number) == false)
						{
							result.Combination.Add(number);
						}
						else
						{
							result.Errors.Push("There are repetitions,");
						}
					}
					else
					{
						result.Errors.Push("Number is out of range.");
					}
				}
			}

			return result;
		}

		public RegisterResult RegisterJackpot(string combination)
		{
			var result = this.RegisterCombination(combination);

			if (result.Success())
			{
				if (result.Combination.Count() == DefaultValues.JACKPOT_NUMBERS_COUNT)
				{
					jackpot = result.Combination;
				}
				else
				{
					result.Errors.Push("Combination count should match the count of numbers of jackpot.");
				}
			}

			return result;
		}

		public RegisterResult RegisterCheckTalon(string combination)
		{
			var result = this.RegisterCombination(combination);

			if (result.Success())
			{
				if (result.Combination.Count() >= DefaultValues.JACKPOT_NUMBERS_COUNT &&
							result.Combination.Count() <= DefaultValues.END_RANGE_OF_COMBINATION)
				{
					checkTalon = result.Combination;
				}
				else
				{
					result.Errors.Push("Count of numbers is out of range.");
				}
			}
			return result;
		}

		public WinningsResult GetWinnings()
		{
			// keeps errors and also keeps winning values
			WinningsResult result = new WinningsResult();

			if (!IsJackpotRegistered())
			{
				result.Errors.Push("No registered jackpot");
			}
			if (!IsCheckTalonRegistered())
			{
				result.Errors.Push("No registered checktalon");
			}

			if (result.Success())
			{
				// first, we get the count of scored numbers
				// sescond, we count the combinations of n = scored numbers, k  = index of profitable 6,5,4,3. . 
				// third, we count the combinations of n = unscored numbers, k = the offset of index of profitable 6,5,4,3
				// fourth, we multiply the scored and unscored numbers
				// save

				// first step
				var scoredNumbers = this.GetScoredNumbers();

				// we begin to save our winnings from the count of scored numbers
				// all winnings before that index are zeroes
				int indexOfWinnigns = scoredNumbers;
				int unscoredCountOfNumbers = checkTalon.Count - scoredNumbers;

				while (indexOfWinnigns != DefaultValues.END_INDEX_OF_WINNINGS)
				{
					// second step
					ulong combinationsOfScoredNumbers = Combinatoric.GetCombinationsWithNoRepetitions(scoredNumbers, indexOfWinnigns);

					// third step
					int countOfNumbersFarFromJackpot = DefaultValues.JACKPOT_NUMBERS_COUNT - indexOfWinnigns;
					ulong combinationsOfUnscoredNumbers = Combinatoric.GetCombinationsWithNoRepetitions(unscoredCountOfNumbers, countOfNumbersFarFromJackpot);

					// fourth step
					var profitableCombinationsForIndex = combinationsOfScoredNumbers * combinationsOfUnscoredNumbers;

					// save combinations for profitable combinations in an array
					result.Winnings[indexOfWinnigns - 1] = profitableCombinationsForIndex;
					indexOfWinnigns--;
				}
			}

			return result;
		}

		public int GetScoredNumbers()
		{
			int scoredNumbers = 0;

			foreach (var number in this.jackpot)
			{
				if (this.checkTalon.Contains(number))
				{
					scoredNumbers++;
				}
			}
			return scoredNumbers;
		}


		public bool IsCheckTalonRegistered()
		{
			if(checkTalon == null)
			{
				return false;
			}
			return true;
		}

		public bool IsJackpotRegistered()
		{
			if (jackpot == null)
			{
				return false;
			}
			return true;
		}
	}
}
