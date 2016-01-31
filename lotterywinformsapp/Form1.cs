using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LotteryData;

namespace LotteryWinFormsApp
{
	public partial class Form1 : Form
	{
		private Lottery lottery;
		public Form1()
		{
			InitializeComponent();
			lottery = new Lottery();
		}

		private void buttonWinnings_Click(object sender, EventArgs e)
		{
			DeletePreviousErrors();

			// delete previous winnings
			labelWinnings.Text = "";

			var result = lottery.GetWinnings();
			if(result.Success())
			{
				DisplayWinnings(result);
			}
			else
			{
				AddErrorsToLabel(result);
			}
		}

		private void textBoxCheckTalon_TextChanged(object sender, EventArgs e)
		{
			DeletePreviousErrors();
			
			var combination = textBoxCheckTalon.Text;
			var result = lottery.RegisterCheckTalon(combination);
			if(result.Success())
			{
				labelRegCheckTalon.Text = "Check Talon Registered: " + textBoxCheckTalon.Text;
			}
			else
			{
				AddErrorsToLabel(result);
			}
		}

		private void DeletePreviousErrors()
		{
			labelErrors.Text = "";
		}

		private void AddErrorsToLabel(RegisterResult result)
		{
			foreach (var error in result.Errors)
			{
				labelErrors.Text += error;
				labelErrors.Text += "\n";
			}
		}

		private void textBoxJackpot_TextChanged(object sender, EventArgs e)
		{
			DeletePreviousErrors();

			var combination = textBoxJackpot.Text;
			var result = lottery.RegisterJackpot(combination);
			if (result.Success())
			{
				labelRegJackpot.Text = "Jackpot registered: " + textBoxJackpot.Text;
			}
			else
			{
				AddErrorsToLabel(result);
			}
		}

		private void DisplayWinnings(WinningsResult result)
		{
			int i = DefaultValues.JACKPOT_NUMBERS_COUNT;
			for (; i > DefaultValues.END_INDEX_OF_WINNINGS; i--)
			{
				labelWinnings.Text += "Profitable combinations for " + i + " :" + result.Winnings[i - 1] + "\n";
			}
		}


	}
}
