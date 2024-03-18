using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA2
{
	class DataAccessLayer
	{
		private string dBConnection = @"Server=uwdb18.srv.lu.se\icssql001; Database=SYSA14_PK_ProgAssignment2; User ID = sysa14reader; Password = INFreader1";

		// Method for returning a populated datatable with values from the database

		public DataTable DataTableReturner(string query)
		{
			using (SqlConnection sQLConnection = new SqlConnection(dBConnection))
			{
				using (SqlCommand command = new SqlCommand(query, sQLConnection))
				{				
					command.Connection.Open();
					SqlDataReader dataReader = command.ExecuteReader();

					DataTable dataTable = new DataTable();
					dataTable.Load(dataReader);
					return dataTable;
				}
			}
		}
	}
}
