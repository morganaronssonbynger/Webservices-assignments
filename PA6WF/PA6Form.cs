using PA6WF.ServiceReferencePA6;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA6WF
{
	public partial class PA6Form : Form
	{

		WebServicePA6SoapClient client = new WebServicePA6SoapClient();

		// Default constructor for PA6Form that also adds items in our combobox when the client is started

		public PA6Form()
		{
			InitializeComponent();
			comboBoxOptions.Items.AddRange(new object[] { "Employees and relatives", "People who were sick year 2004", "Most abscense", "Employee columns 1", "Employee columns 2", "Tables 1", "Tables 2", "Table constraints", "Table indexes", "Key constraints", "Metadata" });
            dataGridViewDataDisplayer.AllowUserToAddRows = false;
        }

		// Method that populates the datagridview depending on which index is selected in the combobox

		private void ComboBoxOptions_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
                //ComboBox index 0 is Employees and Relatives
				if (comboBoxOptions.SelectedIndex == 0)
				{
					List<ArrayOfString> employeeAndRelativeList = client.GetEmployeesAndRelatives();
					List<string> columnNames = new List<string>() { "No_ ", "First Name", "Last Name", "Address", "Job Title", "Relative Code", "Relative First Name", "Relative Last Name" };
					DataTable table = ConvertListToDataTable(employeeAndRelativeList, columnNames);
					dataGridViewDataDisplayer.DataSource = table;
				}

                //ComboBox index 1 is Employees who where sick 2004
                else if (comboBoxOptions.SelectedIndex == 1)
				{
					List<ArrayOfString> employeeWhoWereSick2004List = client.GetEmployeesWhoWhereSick2004();
					List<string> columnNames = new List<string>() { "No_ ", "First Name", "Last Name", "Address", "Job Title" };
					DataTable table = ConvertListToDataTable(employeeWhoWereSick2004List, columnNames);
					dataGridViewDataDisplayer.DataSource = table;
				}

                //ComboBox index 2 is Employee with most absence
                else if (comboBoxOptions.SelectedIndex == 2)
				{
					List<ArrayOfString> employeeWithMostAbsenceList = client.GetEmployeesWithMostAbscense();
					List<string> columnNames = new List<string>() { "First Name" };
					DataTable table = ConvertListToDataTable(employeeWithMostAbsenceList, columnNames);
					dataGridViewDataDisplayer.DataSource = table;
				}

                //ComboBox index 3 is one version to get Employee columns
                else if (comboBoxOptions.SelectedIndex == 3)
				{
					List<ArrayOfString> employeeColumnList = client.GetEmployeeColumnsOne();
					List<string> columnNames = new List<string>() { "Column Name" };
					DataTable table = ConvertListToDataTable(employeeColumnList, columnNames);
					dataGridViewDataDisplayer.DataSource = table;
				}

                //ComboBox index 4 is another version to get Employee columns
                else if (comboBoxOptions.SelectedIndex == 4)
				{
					List<ArrayOfString> employeeColumnList = client.GetEmployeeColumnsTwo();
					List<string> columnNames = new List<string>() { "Column Name" };
					DataTable table = ConvertListToDataTable(employeeColumnList, columnNames);
					dataGridViewDataDisplayer.DataSource = table;
				}

                //ComboBox index 5 is one version to get all tables
                else if (comboBoxOptions.SelectedIndex == 5)
				{
					List<ArrayOfString> tablesList = client.GetTablesMethodOne();
					List<string> columnNames = new List<string>() { "Table Name" };
					DataTable table = ConvertListToDataTable(tablesList, columnNames);
					dataGridViewDataDisplayer.DataSource = table;
				}

                //ComboBox index 6 is another version to get all tables
                else if (comboBoxOptions.SelectedIndex == 6)
				{
					List<ArrayOfString> tablesList = client.GetTablesMethodTwo();
					List<string> columnNames = new List<string>() { "Table Name" };
					DataTable table = ConvertListToDataTable(tablesList, columnNames);
					dataGridViewDataDisplayer.DataSource = table;
				}

                //ComboBox index 7 is table constraints
                else if (comboBoxOptions.SelectedIndex == 7)
				{
					List<ArrayOfString> tableConstraintsList = client.GetTableConstraints();
					List<string> columnNames = new List<string>() { "Constraint name", "Table name", "Constraint type" };
					DataTable table = ConvertListToDataTable(tableConstraintsList, columnNames);
					dataGridViewDataDisplayer.DataSource = table;
				}

                //ComboBox index 8 is indexes
                else if (comboBoxOptions.SelectedIndex == 8)
				{
					List<ArrayOfString> indexesList = client.GetIndexes();
					List<string> columnNames = new List<string>() { "Object id", "Name", "Index id", "Type" };
					DataTable table = ConvertListToDataTable(indexesList, columnNames);
					dataGridViewDataDisplayer.DataSource = table;
				}

                //ComboBox index 9 is key constraints
                else if (comboBoxOptions.SelectedIndex == 9)
				{
					List<ArrayOfString> keyConstraintsList = client.GetKeyConstraints();
					List<string> columnNames = new List<string>() { "Name", "Type" };
					DataTable table = ConvertListToDataTable(keyConstraintsList, columnNames);
					dataGridViewDataDisplayer.DataSource = table;
				}

                //ComboBox index 10 is metadata from all employee realated tables
                else if (comboBoxOptions.SelectedIndex == 10)
				{
					List<ArrayOfString> metaDataFromEmployeeTableList = client.GetMetaDataFromEmployeeTable();
					List<string> columnNames = new List<string>() { "Name", "Object id", "Type", "Type desc" };
					DataTable table = ConvertListToDataTable(metaDataFromEmployeeTableList, columnNames);
					dataGridViewDataDisplayer.DataSource = table;
				}
			}
			catch(Exception ex)
			{
				string errorMessage = ExceptionHandler.HandleException(ex);
				string title = "Error message";
				MessageBox.Show(errorMessage, title);
			}


		}

        // Classmethod that returns and converts a List of String Arrays to a datatable that also populates the columns of the datatable

        static DataTable ConvertListToDataTable(List<ArrayOfString> list, List<string> columnList)
        {
            // New table.
            DataTable table = new DataTable();

            // Get max columns.
            // https://www.dotnetperls.com/convert-list-datatable 
            int columns = 0;
            foreach (var array in list)
            {
                if (array.Count > columns)
                {
                    columns = array.Count;
                }
            }

            // Add columns.
            for (int i = 0; i < columns; i++)
            {
                table.Columns.Add(columnList[i]);

            }

            // Add rows.
            foreach (var array in list)
            {
                table.Rows.Add(array.ToArray());
            }

            return table;
        }
    }
}
