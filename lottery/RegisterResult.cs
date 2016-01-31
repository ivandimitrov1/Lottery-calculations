using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryData
{
	public class RegisterResult
	{
		private Stack<string> errors;
		public RegisterResult()
		{
			errors = new Stack<string>();
		}

		public Stack<string> Errors
		{
			get
			{
				if (errors == null)
				{
					throw new ArgumentNullException();
				}
				return this.errors;
			}
			protected set
			{
				this.errors = value;
			}
		}
		public bool Success()
		{
			if (Errors.Count == 0)
			{
				return true;
			}
			return false;
		}
	}
}
