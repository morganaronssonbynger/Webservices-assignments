using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PA6WS
{
	public class DataAccessLayer
	{
		private string dBConnection = "Server=localhost; Database=Demo Database NAV (5-0); User ID = user1; Password = mage123";

        // Method that gets information from the database depending on which query is passed through and returns the calues in a list of string arrays
        //test
        public List<string[]> GetDataFromDatabase(string query)
        {
            using (SqlConnection sQLConnection = new SqlConnection(dBConnection))
            {
                using (SqlCommand command = new SqlCommand(query, sQLConnection))
                {
                    List<string[]> listOfObjects = new List<string[]>();

                    command.Connection.Open();
                    SqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        string[] stringArray = new string[dataReader.FieldCount];

                        for(int i = 0; i < dataReader.FieldCount; i++)
                        {
							stringArray[i] = dataReader.GetValue(i).ToString();   
                        }

                        listOfObjects.Add(stringArray);
                    }

                    return listOfObjects;

                }
            }
        }

    }
}