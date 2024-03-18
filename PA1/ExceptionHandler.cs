using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA1
{
    class ExceptionHandler
    {

		// Method for handling our exceptions and returns a string depending on which errorcode is catched

        public static string HandleException(Exception ex)
        {
            //Checking if exceptions is of type SQLException.
			if(ex is SqlException)
			{			
				SqlException sQL = ex as SqlException;

                // Exception if database server is down/disconnected.

				if (sQL.Number == 2)
				{
					return "Connection errors, please check your connection.";
				}

				// Exception if the user inputs letters instead of digits for the column amount

				else if (sQL.Number == 245)
                {
                    return " Please type the amount with numbers";
                }

				// Exception if you try to remove a customer when they have one or several accounts connected to it, FK constraint

                else if (sQL.Number == 547)
				{
					return "You need to remove the persons accounts before removing the person from the register.";
				}

				// Exception when trying to add a customer or an account with the same value for their primary key, SSN, AccountNumber, PK constraint

				else if (sQL.Number == 2627)
				{
					if (sQL.Message.Contains("'dbo.Customer'"))
					{
						return "A customer with that SSN already exists.";
					}
					else if (sQL.Message.Contains("'dbo.Account'"))
					{
						return "Something went wrong, please try creating a new account.";
					}

                    // Messege for unexpected errors

                    else
                    {
						return "Try to restart the program if it is still not working please call our customer service at: 0730880819";
					}
				}

				// Exception if the user try to input a value greater than what the char can hold in the database

				else if (sQL.Number == 2628)
				{
					return "You have written to many characters please try fewer characters. Maximum amount of characters for Name and adress are 50.";
				}

				// Exception if the user try to put a value greater than the attribute can hold, in our case it is an exception that can occur for the attribute amount

				else if (sQL.Number == 8115)
				{
					return "Amount exceeds our banking limit, please divide the money into seperate accounts.";
				}

                // Messege for unexpected errors

				else
				{
					return "Try to restart the program if it is still not working please call our customer service at: 0730880819";
				}
			}

			// Exception if the user try to put a value greater than the attribute can hold, in our case it is an exception that can occur for the attribute amount

			else if (ex is OverflowException)
			{
				return "The amount you are trying to deposit or withdraw exceeds our banking limit.";
			}

            // Messege for unexpected errors

            else
            {
				return "Try to restart the program if it is still not working please call our customer service at: 0730880819";
			}
			
		}
	}
    
}
