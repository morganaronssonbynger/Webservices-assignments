using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using PA5WF.ServiceReferencePA5WS;

namespace PA5WF
{
    public partial class PA5Form : Form
    {
		ExceptionHandler eH = new ExceptionHandler();
        WebServicePA5SoapClient proxy = new WebServicePA5SoapClient();

		// PA5Form default constructor that populates our comboboxes when client starts

        public PA5Form()
        {
            InitializeComponent();
            this.Populate_comboBox();
            dataGridViewSearchEmployee.AllowUserToAddRows = false;
        }

		// Method that gets all the employees from the database

        private void BtnGetEmployees_Click(object sender, EventArgs e)
        {
			try
			{
				List<CRONUS_Sverige_AB_Employee> empList = proxy.GetEmployees();

				List<string[]> employeeList = new List<string[]>();
				List<string> columnNamesList = new List<string>() { "No_", "First Name", "Last Name", "Address", "Job Title" };

				foreach (CRONUS_Sverige_AB_Employee emp in empList)
				{
					string[] employeeArray = new string[5];
                    employeeArray[0] = emp.No_;
                    employeeArray[1] = emp.First_Name;
                    employeeArray[2] = emp.Last_Name;
                    employeeArray[3] = emp.Address;
                    employeeArray[4] = emp.Job_Title;

                    employeeList.Add(employeeArray);
				}
				DataTable dataTable = ConvertListToDataTable(employeeList, columnNamesList);
				dataGridViewSearchEmployee.DataSource = dataTable;
			}
			catch(Exception ex)
			{
                string errorMessage = eH.HandleException(ex);
                string title = "Error message";
                MessageBox.Show(errorMessage, title);
            }
        }

		// Method that gets information about a employee and displays it in a datagridview

		private void BtnSearch_Click(object sender, EventArgs e)
		{
            if (string.IsNullOrEmpty(comboBox_GetEmployee.Text))
            {
                string message = "You have to chose a Employee number";
                string title = "Error message";
                MessageBox.Show(message, title);
            }
            else
            {
                try
                {
                    CRONUS_Sverige_AB_Employee emp = proxy.GetEmployee(comboBox_GetEmployee.Text.Substring(0, 2));

                    List<string[]> employeeList = new List<string[]>();
                    List<string> columnNamesList = new List<string>() { "No_", "First Name", "Last Name", "Address", "Job Title" };

                    string[] employeeArray = new string[5];

                    employeeArray[0] = emp.No_;
                    employeeArray[1] = emp.First_Name;
                    employeeArray[2] = emp.Last_Name;
                    employeeArray[3] = emp.Address;
                    employeeArray[4] = emp.Job_Title;
                    employeeList.Add(employeeArray);

                    DataTable dataTable = ConvertListToDataTable(employeeList, columnNamesList);
                    dataGridViewSearchEmployee.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    string errorMessage = eH.HandleException(ex);
                    string title = "Error message";
                    MessageBox.Show(errorMessage, title);
                }
            }			
		}

		// Method for creating a new employee

		private void BtnAdd_Click(object sender, EventArgs e)
		{
			if(string.IsNullOrEmpty(textBoxFirstNameAdd.Text) || string.IsNullOrEmpty(textBoxLastNameAdd.Text) || string.IsNullOrEmpty(textBoxAddressAdd.Text) || string.IsNullOrEmpty(textBoxJobTitleAdd.Text))
			{
				textBoxDisplayAddEmployee.Text = "Please fill out all the required fields, which is: First Name, Last Name, Address, Job Title.";
			}
			else if (!Regex.IsMatch(textBoxFirstNameAdd.Text, @"^[A-Öa-ö\-]+$"))
			{
				textBoxDisplayAddEmployee.Text = "Please write the First name in the right format, characters who are allowed are: A-Ö and -.";
			}
			else if (!Regex.IsMatch(textBoxLastNameAdd.Text, @"(^[A-öa-ö]+)\s*([A-Öa-ö]+$)"))
			{
				textBoxDisplayAddEmployee.Text = "Please write the Last name in the right format. Two last names are allowed and characters from A-Ö.";
			}
			else if(!Regex.IsMatch(textBoxJobTitleAdd.Text, @"(^[A-öa-ö]+)\s*([A-Öa-ö]+)\s*([A-Öa-ö]+$)"))
			{
				textBoxDisplayAddEmployee.Text = "Please write the Job title with letters only from A-Ö";
			}
			else
			{
				try
				{
					string firstName = textBoxFirstNameAdd.Text;
					string lastName = textBoxLastNameAdd.Text;
					string address = textBoxAddressAdd.Text;
					string jobTitle = textBoxJobTitleAdd.Text;
                    string initials = firstName.Substring(0, 1).ToUpper() + lastName.Substring(0, 1).ToUpper();


                    proxy.CreateEmployee(firstName, lastName, address, jobTitle);
					this.Populate_comboBox();

                    textBoxDisplayAddEmployee.Text = "Employee with these values were successfully added!" + Environment.NewLine + "First name: " +  firstName + Environment.NewLine + "Last name: " +  lastName + Environment.NewLine+  "Address: " + address + Environment.NewLine + "Job title " + jobTitle + Environment.NewLine +  "Initials: " + initials + " will be used.";
                    textBoxFirstNameAdd.Clear();
                    textBoxLastNameAdd.Clear();
                    textBoxAddressAdd.Clear();
                    textBoxJobTitleAdd.Clear();
                }
				catch (Exception ex)
				{
					string errorMessage = eH.HandleException(ex);
					textBoxDisplayAddEmployee.Text = errorMessage;
				}
			}
		}

		// Method for removing an employee from the database

        private void BtnRemove_Click(object sender, EventArgs e)
        {
			if (string.IsNullOrEmpty(comboBox_removeEmployee.Text))
			{
				textBoxDisplayRemoveEmployee.Text = "Please select a No_ before removing.";
			}
			else
			{
				try
				{
					string no_ = comboBox_removeEmployee.Text.Substring(0, 2);
					proxy.RemoveEmployee(no_);

					textBoxDisplayRemoveEmployee.Text = no_ + " was succesfully removed.";
					comboBox_removeEmployee.Text = "";
					this.Populate_comboBox();
				}
				catch (Exception ex)
				{
					string errorMessage = eH.HandleException(ex);
					textBoxDisplayRemoveEmployee.Text = errorMessage;
				}
			}           
        }

		// Method for updating an employees informaton

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
			if (string.IsNullOrEmpty(comboBox_updateEmployee.Text))
			{
				textBoxDisplayUpdate.Text = "Please select a No_ before updating.";
			}
			else if(string.IsNullOrEmpty(textBoxFirstNameUpdate.Text) || string.IsNullOrEmpty(textBoxLastNameUpdate.Text) || string.IsNullOrEmpty(textBoxAddressUpdate.Text) || string.IsNullOrEmpty(textBoxJobTitleUpdate.Text))
			{
				textBoxDisplayUpdate.Text = "Please fill out all the required fields, which is: First Name, Last Name, Address, Job Title.";
			}
			else if (!Regex.IsMatch(textBoxFirstNameUpdate.Text, @"^[A-Öa-ö\-]+$"))
			{
				textBoxDisplayUpdate.Text = "Please write the First name in the right format, characters who are allowed are: A-Ö and -.";
			}
			else if (!Regex.IsMatch(textBoxLastNameUpdate.Text, @"(^[A-öa-ö]+)\s*([A-Öa-ö]+$)"))
			{
				textBoxDisplayUpdate.Text = "Please write the Last name in the right format. Two last names are allowed and characters from A-Ö.";
			}
			else if (!Regex.IsMatch(textBoxJobTitleUpdate.Text, @"(^[A-öa-ö]+)\s*([A-Öa-ö]+)\s*([A-Öa-ö]+$)"))
			{
				textBoxDisplayUpdate.Text = "Please write the Job title with letters only from A-Ö";
			}
			else
			{
				try
				{
                    string no_ = comboBox_updateEmployee.Text.Substring(0, 2);
					string firstName = textBoxFirstNameUpdate.Text;
                    string lastName = textBoxLastNameUpdate.Text;
					string address = textBoxAddressUpdate.Text;
					string jobTitle = textBoxJobTitleUpdate.Text;

					proxy.UpdateEmployee(no_, firstName, lastName, address, jobTitle);
                    this.Populate_comboBox();

                    textBoxDisplayUpdate.Text = "Update of employee " + no_ + " was a success!" + Environment.NewLine +  "New values are: " + Environment.NewLine +  "First name: " + firstName + Environment.NewLine + "Last name: " + lastName + Environment.NewLine + "Address: " + address + Environment.NewLine + "Job title: " + jobTitle;

                    comboBox_updateEmployee.Text = "";
                    textBoxFirstNameUpdate.Clear();
                    textBoxLastNameUpdate.Clear();
                    textBoxAddressUpdate.Clear();
                    textBoxJobTitleUpdate.Clear();
                }
				catch (Exception ex)
				{
					string errorMessage = eH.HandleException(ex);
					textBoxDisplayUpdate.Text = errorMessage;
				}
			}
        }

		// Method for populating our textboxes in update depending on which value is selected in the combobox

		private void ComboBox_updateEmployee_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				string no_ = comboBox_updateEmployee.Text.Substring(0,2);
				CRONUS_Sverige_AB_Employee emp = proxy.GetEmployee(no_);

				textBoxFirstNameUpdate.Text = emp.First_Name;
				textBoxLastNameUpdate.Text = emp.Last_Name;
				textBoxAddressUpdate.Text = emp.Address;
				textBoxJobTitleUpdate.Text = emp.Job_Title;
			}
			catch (Exception ex)
			{
				string errorMessage = eH.HandleException(ex);
                textBoxDisplayUpdate.Text = errorMessage;
            }
		}

        // Method for populating our comboboxes

        private void Populate_comboBox()
        {
            try
            {
                List<CRONUS_Sverige_AB_Employee> employeeList = proxy.GetEmployees();

                //Have to clear all comboboxes everytime method is called, so no duplications appear.
                comboBox_GetEmployee.Items.Clear();
                comboBox_removeEmployee.Items.Clear();
                comboBox_updateEmployee.Items.Clear();
                foreach (CRONUS_Sverige_AB_Employee emp in employeeList)
                {
                    comboBox_GetEmployee.Items.Add(emp.No_ + " - " + emp.First_Name + " " + emp.Last_Name);
                    comboBox_removeEmployee.Items.Add(emp.No_ + " - " + emp.First_Name + " " + emp.Last_Name);
                    comboBox_updateEmployee.Items.Add(emp.No_ + " - " + emp.First_Name + " " + emp.Last_Name);
                }

                // Clears the fields and comboboxes so if an employee is selected when removed they are removed from the fields.
                comboBox_GetEmployee.Text = null;
                comboBox_removeEmployee.Text = null;
                comboBox_updateEmployee.Text = null;
                textBoxFirstNameUpdate.Text = null;
                textBoxLastNameUpdate.Text = null;
                textBoxAddressUpdate.Text = null;
                textBoxJobTitleUpdate.Text = null;
            }
            catch (Exception ex)
            {
                string errorMessage = eH.HandleException(ex);
            }
        }

        // Method that converts List<String[]> to a DataTable and also adds the column names

        static DataTable ConvertListToDataTable(List<string[]> list, List<string> columnNames)
        {
            // New table.
            DataTable table = new DataTable();

            // Get max columns.
            // https://www.dotnetperls.com/convert-list-datatable 
            int columns = 0;
            foreach (var array in list)
            {
                if (array.Length > columns)
                {
                    columns = array.Length;
                }
            }

            // Add columns.
            for (int i = 0; i < columns; i++)
            {
                table.Columns.Add(columnNames[i]);
            }

            // Add rows.
            foreach (var array in list)
            {
                table.Rows.Add(array);
            }
            return table;
        }
    }
}
