using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA2
{
	class ExceptionHandler
	{

		// Method for handling our exceptions and returns a string dependent on what the errormessage contains

		public string HandleException(Exception ex)
		{
            // Error message if there is no connection

            if (ex.Message.Contains("error: 40 "))
			{
				return "Check your internet connection or contact our IT support at: 0730880819";
			}

            // Error message for failing to access database

            else if (ex.Message.Contains("Cannot open database"))
			{
				return "Connection failed to the database, please check if the name is spelled correctly for the database or if the username and/or password is correct, or if the user has access to the database";
			}

            // Error message for server connection

            else if (ex.Message.Contains("error: 26"))
			{
				return "Connection failed to the server please check if you are connected to the server.";
			}

            //Error messege when unknown error

			else
			{
				return "Try to restart the program if it is still not working please call our customer service at: 0730880819";
			}
		}
	}
}
