using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA5WF
{
    class ExceptionHandler
    {

		// Method that handles our exceptions, it returns an errormessage in the form of a string depending on what the errormessage contains

        public string HandleException(Exception ex)
        {
            //Error messege for primary key violation

            if (ex.Message.Contains("Violation of PRIMARY KEY"))
            {
                return "A person with these initials already exist please try another one.";
            }

            // Error message if there is no connection

            else if (ex.Message.Contains("error: 40 "))
			{
				return "Check your internet connection or contact our IT support at: 0730880819";
			}

            // Error message for failing to access database

            else if (ex.Message.Contains("Cannot open database"))
			{
				return "Connection failed to the database, please check if the name is spelled correctly for the database" + "\n or if the username and/or password is correct, or if the user has access to the database";
			}

            // Error message for server connection

            else if (ex.Message.Contains("error: 26"))
			{
				return "Connection failed to the server please check if you are connected to the server.";
			}

            //Error messege for exceeding character limit

            else if (ex.Message.Contains("System.Data.Entity.Validation.DbEntityValidationException"))
			{
				return "The amount of characters exceeds the limit of the database, the maximum amount of characters for First Name, Last Name, Job Title is 30 characters, the maximum amount for Address is 50.";
			}

            //Error messege when unknown error

            else
            {
                return "Try to restart the program if it is still not working please call our customer service at: 0730880819";
            }
			
        }
    }
}
