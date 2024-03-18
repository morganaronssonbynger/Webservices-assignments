using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA2
{
	public partial class PA2Form : Form
	{
		DataAccessLayer dAL = new DataAccessLayer();
		SQLquaries sQL = new SQLquaries();
		ExceptionHandler eH = new ExceptionHandler();

		// Default constructor for the form

		public PA2Form()
		{
			InitializeComponent();
			dataGridViewMetaData.AllowUserToAddRows = false;
		}

		// Method for getting the number of rows from the tables in tableofinterest

		private void BtnGetNrOfRows_Click(object sender, EventArgs e)
		{
			try
			{
				string query = sQL.GetNrOfRows();
				dataGridViewMetaData.DataSource = dAL.DataTableReturner(query);
			}
			catch(Exception ex)
			{
                string title = "Error message";
                string errorMessage = eH.HandleException(ex);
                MessageBox.Show(errorMessage, title);
				
			}			
		}

		// Method for getting all the columns from the tables in tableofinterest

		private void BtnGetAllColumns_Click(object sender, EventArgs e)
		{
			try
			{
				string query = sQL.GetAllColumns();
				dataGridViewMetaData.DataSource = dAL.DataTableReturner(query);
			}
			catch(Exception ex)
			{
                string title = "Error message";
                string errorMessage = eH.HandleException(ex);
                MessageBox.Show(errorMessage, title);
            }
		}
	}
}
