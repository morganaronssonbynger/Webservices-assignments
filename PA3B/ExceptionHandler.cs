using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA3B
{
	class ExceptionHandler
	{

		// Method for handling our exceptions, returns a string with a message depending on what error contains in the message

		public static string HandleException(Exception ex)
		{
            // Error message if text field is empty

            if (ex.ToString().Contains("ArgumentException"))
			{
				return "You cannot search for an empty filepath, please try again";
			}

            // Error message if file cannot be found

            else if (ex.ToString().Contains("System.IO.FileNotFoundException"))
			{
				return "Could not find the file with that file path, please try another";
			}

            // Error message if the file is restricted 

            else if (ex.ToString().Contains("System.UnauthorizedAccessException"))
			{
				return "You are not authorized to see the contents of that file";
			}

            // Error message for unexpected error

            else
            {
				return "Try to restart the program if it is still not working please call our customer service at: 0730880819";
			}
		}	
	}
}
