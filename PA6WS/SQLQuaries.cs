using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PA6WS
{
	public class SQLQuaries
	{
		// Returns a query in a string that gets all the employees who where abscent due to sickness

		public string GetEmployeesWhoWhereSick2004()
		{
			return "SELECT [No_], [First Name], [Last Name], [Address], [Job Title] FROM [CRONUS Sverige AB$Employee] WHERE No_ IN (SELECT [Employee No_] FROM [CRONUS Sverige AB$Employee Absence] WHERE [Cause of Absence Code] = 'SJUK' AND [From Date] LIKE '%2004%')";
		}

		// Returns a query in a string that gets the person who has been abscent the most

		public string GetEmployeeWithMostAbscense()
		{
			return "SELECT [First Name] FROM [CRONUS Sverige AB$Employee] WHERE No_ IN (SELECT TOP 1 [Employee No_] FROM [CRONUS Sverige AB$Employee Absence] GROUP BY [Employee No_] ORDER BY COUNT([Employee No_]) DESC)";
		}

		// Returns a query in a string that gets information about the employees and their relatives

		public string GetEmployeesAndRelatives()
		{
			return "SELECT e.[No_], e.[First Name], e.[Last Name], e.Address, e.[Job Title], eR.[Relative Code], eR.[First Name], eR.[Last Name] FROM[CRONUS Sverige AB$Employee] e JOIN[CRONUS Sverige AB$Employee Relative] eR ON e.No_ = eR.[Employee No_]";
		}

		// Returns a query in a string that gets metadata from the employee table

		public string GetMetaDataFromEmployeeTable()
		{
			return "SELECT name, object_id, type, type_desc FROM sys.objects WHERE  name LIKE 'CRONUS Sverige AB$Employee%'";
		}

		// Returns a query in a string that gets the top 250 key constraints, types and names

		public string GetKeyConstraints()
		{
			return "SELECT TOP 250 name, type FROM sys.key_constraints";
		}

		// Returns a query in a string that gets the top 250 indexes, object_ids, names, index_ids from the database

		public string GetIndexes()
		{
			return "SELECT TOP 250 object_id, name, index_id, type FROM sys.indexes";
		}

		// Returns a query in a string that gets the top 250 Table constraint names, tablenames and constraint types from the database

		public string GetTableConstraints()
		{
			return "SELECT TOP 250 CONSTRAINT_NAME, TABLE_NAME, CONSTRAINT_TYPE FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS";
		}

		// Returns a query in a string that gets the top 500 table names from the database

		public string GetTablesMethodOne()
		{
			return "SELECT TOP 500 TABLE_NAME FROM INFORMATION_SCHEMA.TABLES";
		}

		// Returns a query in a string that gets the top 500 table names from the database

		public string GetTablesMethodTwo()
		{
			return "SELECT TOP 500 name FROM sys.tables";
		}

		// Returns a query in a string that gets the top 500 column names from the database

		public string GetEmployeeColumnsOne()
		{
			return "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'CRONUS Sverige AB$Employee'";
		}

		// Returns a query in a string that gets the top 500 column names from the database

		public string GetEmployeeColumnsTwo()
		{
			return "SELECT name FROM sys.all_columns WHERE object_id = 199671759";
		}
	}
}