using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LotteryData;

namespace LotteryConsoleApp
{
	class Program
	{
		public delegate RegisterResult RegisterCombination(string numbers);
		static void Main(string[] args)
		{
			Lottery lottery = new Lottery();

			InputData("Enter check talon combination, example : 1,2,5,7,9,19 or more numbers", lottery.RegisterCheckTalon);
			InputData("Enter jackpot combination, example : 1,2,5,7,9,19 or more numbers", lottery.RegisterJackpot);

			var winnigsResult = lottery.GetWinnings();
			if (winnigsResult.Success())
			{
				DisplayWinnigs(winnigsResult);
			}
			else
			{
				DisplayErrorMessages(winnigsResult);
			}
		}

		static void InputData(string enterLine, RegisterCombination registerCombination)
		{
			var result = true;
			Console.WriteLine(enterLine);
			while (result)
			{
				var combination = Console.ReadLine();
				var response = registerCombination(combination);
				if (response.Success())
				{
					break;
				}
				else
				{
					DisplayErrorMessages(response);
					Console.WriteLine("Enter data again");
				}
			}
		}

		static void DisplayErrorMessages(RegisterResult result)
		{
			foreach (var error in result.Errors)
			{
				Console.WriteLine(error);
			}
		}

		static void DisplayWinnigs(WinningsResult result)
		{
			int i = DefaultValues.JACKPOT_NUMBERS_COUNT;

			for (; i > DefaultValues.END_INDEX_OF_WINNINGS; i--)
			{
				Console.WriteLine("Count of profitable combinations for " + i + " :" + result.Winnings[i - 1]);
			}
		}
	}
}
