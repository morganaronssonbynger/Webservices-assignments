using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA4A
{
    class Program
    {
        static void Main(string[] args)
        {
			WebServicePA4 proxy = new WebServicePA4();

			try
			{
				
				Customer[] customerArray = proxy.GetCustomers();

                Console.WriteLine("Customers: \n");
                foreach (Customer customer in customerArray)
				{
					Console.WriteLine(customer.SSN + " " + customer.Name + " " + customer.Address + " " + customer.PhoneNumber);
				}

				Console.WriteLine();
                Console.WriteLine("Accounts: \n");

                Account[] accountArray = proxy.GetAccounts();

				foreach (Account account in accountArray)
				{
					Console.WriteLine(account.AccountNumber + " " + account.Balance + " " + account.CustomerSSN);
				}

				Console.Read();
			}
			catch(Exception ex)
			{
				string errorMessage = ExceptionHandler.HandleException(ex);
				Console.WriteLine(errorMessage);
				Console.Read();
			}

        }
    }
}
