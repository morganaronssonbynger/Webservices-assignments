using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA1
{
	static class Utility
	{

		// Method for splitting our strings from our comboboxes

		public static string SplitMethod(string tmp)
		{
			char[] delim = new char[] { ' ', '-' };
			string[] array = tmp.Split(delim);
			return array[0];
		}
	}
}
