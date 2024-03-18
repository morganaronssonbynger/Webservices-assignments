using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace PA6WS
{
	/// <summary>
	/// Summary description for WebServicePA6
	/// </summary>
	[WebService(Namespace = "http://tempuri.org/")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[System.ComponentModel.ToolboxItem(false)]
	// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
	// [System.Web.Script.Services.ScriptService]
	public class WebServicePA6 : System.Web.Services.WebService
	{
		DataAccessLayer dAL = new DataAccessLayer();
		SQLQuaries sQL = new SQLQuaries();
        
		// Webmethod that returns a List of string arrays with the people who were abscent due to sickness in 2004

		[WebMethod]
		public List<string[]> GetEmployeesWhoWhereSick2004()
		{
			string query = sQL.GetEmployeesWhoWhereSick2004();
			return dAL.GetDataFromDatabase(query);
		}

		// Webmethod that returns a List of string arrays with the person who has been the most abscent

		[WebMethod]
		public List<string[]> GetEmployeesWithMostAbscense()
		{
			string query = sQL.GetEmployeeWithMostAbscense();
			return dAL.GetDataFromDatabase(query);
		}

		// Webmethod that returns a List of string arrays with the employees and their relatives

		[WebMethod]
        public List<string[]> GetEmployeesAndRelatives()
        {
            string query = sQL.GetEmployeesAndRelatives();
            return dAL.GetDataFromDatabase(query);
        }

		// Webmethod that returns a List of string arrays with metadata from the employeetable

		[WebMethod]
		public List<string[]> GetMetaDataFromEmployeeTable()
		{
			string query = sQL.GetMetaDataFromEmployeeTable();
			return dAL.GetDataFromDatabase(query);
		}

		// Webmethod that returns a List of string arrays with the key constrants in the database

		[WebMethod]
		public List<string[]> GetKeyConstraints()
		{
			string query = sQL.GetKeyConstraints();
			return dAL.GetDataFromDatabase(query);
		}

		// Webmethod that returns a List of string arrays with the indexes from the database

		[WebMethod]
		public List<string[]> GetIndexes()
		{
			string query = sQL.GetIndexes();
			return dAL.GetDataFromDatabase(query);
		}

		// Webmethod that returns a List of string arrays with the table constraints

		[WebMethod]
		public List<string[]> GetTableConstraints()
		{
			string query = sQL.GetTableConstraints();
			return dAL.GetDataFromDatabase(query);
		}

		// Webmethod that returns a List of string arrays with the tables in the database

		[WebMethod]
		public List<string[]> GetTablesMethodOne()
		{
			string query = sQL.GetTablesMethodOne();
			return dAL.GetDataFromDatabase(query);
		}

		// Webmethod that returns a List of string arrays with the tables in the database

		[WebMethod]
		public List<string[]> GetTablesMethodTwo()
		{
			string query = sQL.GetTablesMethodTwo();
			return dAL.GetDataFromDatabase(query);
		}

		// Webmethod that returns a List of string arrays with the columns in the employee table

		[WebMethod]
		public List<string[]> GetEmployeeColumnsOne()
		{
			string query = sQL.GetEmployeeColumnsOne();
			return dAL.GetDataFromDatabase(query);
		}

		// Webmethod that returns a List of string arrays with the columns in the employee table

		[WebMethod]
		public List<string[]> GetEmployeeColumnsTwo()
		{
			string query = sQL.GetEmployeeColumnsTwo();
			return dAL.GetDataFromDatabase(query);
		}



	}
}
