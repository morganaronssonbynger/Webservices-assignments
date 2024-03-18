using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA1
{
    class DataAccessLayer
    {
        private string dBConnection = "Server=localhost; Database=Kritaenfemma; User ID = user1; Password = mage123";

		private List<string> comboBoxList = new List<string>();

		public List<string> ComboBoxList { get => comboBoxList; set => comboBoxList = value; }

		//Method for populating our comboboxlist
		public void PopulateList(string query)
		{
			using (SqlConnection sQLConnection = new SqlConnection(dBConnection))
			{
				using (SqlCommand command = new SqlCommand(query, sQLConnection))
				{					
					command.Connection.Open();
					SqlDataReader dataReader = command.ExecuteReader();

					while (dataReader.Read())
					{
						ComboBoxList.Add(dataReader.GetString(0) + " - " + dataReader.GetString(1));
					}
				}
			}
		}

		//Method for when we need to return a datatables
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

		// Method for when we want to add a new instance to the database or update an objects values or remove an instance from the database
        public void AlterDatabase(string query)
        {
            using (SqlConnection sQLConnection = new SqlConnection(dBConnection))
            {
				using (SqlCommand command = new SqlCommand(query, sQLConnection))
				{
						sQLConnection.Open();
						command.ExecuteNonQuery();					
				}	
            }
        }	
	}
}


