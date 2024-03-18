using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA1
{
    class SQLqueries
    {
        //Customer queries
        public string GetCustomersQuery()
        {
            return "SELECT* FROM Customer";
        }
        public string GetSSNQuery()
        {
            return "SELECT ssn, name FROM Customer";
        }
        public string InsertCustomer(string ssn, string name, string address, string phoneNumber)
        {
            return "INSERT INTO Customer VALUES('" + ssn + "','"+ name +"','" + address + "','" + phoneNumber +"')";
        }
        public string RemoveCustomer(string ssn)
        {
            return "DELETE Customer WHERE ssn = '" + ssn + "'";
        }
		public string GetCustomerQuery(string ssn)
		{
			return "SELECT * FROM Customer WHERE ssn = '" + ssn + "'";
		}
		public string UpdateCustomer(string ssn, string name, string address, string phoneNumber)
		{
			return "UPDATE Customer SET name = '" + name + "', address ='" + address + "', phoneNumber = '" + phoneNumber + "' WHERE ssn = '" + ssn + "'";
		}

        //Account queries 
        public string GetAccountsQuery()
        {
            return "SELECT* FROM Account";
        }
        public string GetAccountNumberQuery()
        {
            return "SELECT accountNumber, customerSsn FROM Account";
        }
        public string RemoveAccount(string accountNumber)
        {
            return "DELETE Account WHERE accountNumber = '" + accountNumber + "'";
        }
        public string InsertAccount(string accountNumber, int balance, string ssn)
        {
            return "INSERT INTO Account VALUES('" + accountNumber + "','" + balance + "','" + ssn + "')";
        }
		public string GetCustomersAccounts(string ssn)
		{
			return "SELECT * FROM Account WHERE customerSsn = '" + ssn + "'";
		}
		public string GetInformationAboutACustomer(string ssn)
		{
			return "SELECT * FROM Customer WHERE ssn = '" + ssn + "'";
		}
		public string WithDrawAmount(int amount, string accountNumber)
		{
			return "UPDATE Account SET balance -= " + amount + "WHERE accountNumber = '" + accountNumber + "'";
		}
		public string DepositAmount(int amount, string accountNumber)
		{
			return "UPDATE Account SET balance += " + amount + "WHERE accountNumber = '" + accountNumber + "'";
		}
		public string CheckAmount(string accountNumber)
		{
			return "SELECT balance FROM Account Where accountNumber = '" + accountNumber + "'";
		}
	}
}
