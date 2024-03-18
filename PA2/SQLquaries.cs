using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA2
{
	class SQLquaries
	{
		// Method that returns the query for getting all the columns from the tables in tableofintrest

		public string GetAllColumns()
		{
			return "SELECT TABLE_NAME, COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME IN(SELECT tableName FROM TablesOfInterest)";
		}

		// Method that returns the query for getting the number of rows from the tables in tableofinterest
		// https://ardalis.com/how-to-find-all-objects-in-a-sql-server-schema/

		public string GetNrOfRows()
		{
			return "SELECT t.name AS TableName, p.rows AS Rows FROM sys.tables t INNER JOIN sys.partitions p ON t.object_id = p.object_id WHERE t.NAME IN (SELECT tableName FROM TablesOfInterest)";
		}
	}
}
