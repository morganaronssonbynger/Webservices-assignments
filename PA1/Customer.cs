using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA1
{
    public partial class Customer : Form
    {
        DataAccessLayer dAL = new DataAccessLayer();
        SQLqueries sQL = new SQLqueries();

		// Default constructor for the customer form

		public Customer()
        {
			try
			{
				InitializeComponent();

                dataGridViewSearchCustomers.AllowUserToAddRows = false;

                string queryGetCustomerSsn = sQL.GetSSNQuery();
				string queryGetAccountNumber = sQL.GetAccountNumberQuery();

				dAL.PopulateList(queryGetCustomerSsn);
				dAL.PopulateList(queryGetAccountNumber);
				foreach (string identifier in dAL.ComboBoxList)
				{
					if (identifier.Substring(0, 4).Equals("5535"))
					{

					}
					else
					{
						this.AddToCustomerComboBox(identifier);
					}
				}
			}
			catch(Exception ex)
			{
				string errorMessage = ExceptionHandler.HandleException(ex);
				string title = "Error message";
				MessageBox.Show(errorMessage, title);
			}       
        }

		// Method for switching to account form, AccountForm is static so you don't have to create a new instance everytime you switch form.

        private void SwitchToAccountForm_Click(object sender, EventArgs e)
        {
            FormList.AccountForm.Show();
            this.Hide();
        }

		// Method for adding ssn to our comboboxes

        public void AddToCustomerComboBox(string sSN)
        {
            comboBoxRemoveCustomer.Items.Add(sSN);
            comboBoxUpdateCustomer.Items.Add(sSN);
            comboBoxSearchCustomers.Items.Add(sSN);
        }

		// Method for removing ssn from our comboboxes

        public void RemoveToCustomerComboBox(string sSN)
        {
            comboBoxRemoveCustomer.Items.Remove(sSN);
            comboBoxSearchCustomers.Items.Remove(sSN);
            comboBoxUpdateCustomer.Items.Remove(sSN);
        }

		// Method for searching on a specific customer

        private void GetCustomer_Click(object sender, EventArgs e)
        {		
			if(string.IsNullOrEmpty(comboBoxSearchCustomers.Text))
			{
                string message = "Please choose a customer before searching";
                string title = "Error message";
                MessageBox.Show(message, title);
            }
			else
			{
				try
				{
					string sSN = Utility.SplitMethod(comboBoxSearchCustomers.Text.ToString());
					string query = sQL.GetInformationAboutACustomer(sSN);
					dataGridViewSearchCustomers.DataSource = dAL.DataTableReturner(query);
					comboBoxSearchCustomers.Text = "";
                }
				catch (Exception ex)
				{
					string errorMessage = ExceptionHandler.HandleException(ex);
                    string title = "Error message";
                    MessageBox.Show(errorMessage, title);
                }
			}
		}

		// Method for getting all customers information from the database

        private void GetAllCustomers_Click(object sender, EventArgs e)
        {
            try
            {
                string query = sQL.GetCustomersQuery();
                dataGridViewSearchCustomers.DataSource = dAL.DataTableReturner(query);
            }
            catch (SqlException ex)
            {
                string errorMessage = ExceptionHandler.HandleException(ex);
                string title = "Error message";
                MessageBox.Show(errorMessage, title);
            }
        }

		// Method for adding a new customer to the database

        private void AddCustomer_Click(object sender, EventArgs e)
		{		
			if (string.IsNullOrEmpty(textBoxAddSsn.Text) || string.IsNullOrEmpty(textBoxAddName.Text) || string.IsNullOrEmpty(textBoxAddAddress.Text) || string.IsNullOrEmpty(textBoxAddPhoneNumber.Text))
			{				
				textBoxDisplayAddCustomer.Text = "Please fill in the required fields, SSN, Name, Address, Phone number";
			}
			else if(!Regex.IsMatch(textBoxAddSsn.Text, "^[0-9]+$") || textBoxAddSsn.Text.Length != 10)
			{
				textBoxDisplayAddCustomer.Text = "Please write the SSN in the right format, which is the SSN with 10 digits.";
			}
			else if (!Regex.IsMatch(textBoxAddName.Text, "(^[A-Öa-ö]+)\\s*([A-Öa-ö]+)\\s*([A-Öa-ö]+$)"))
			{
				textBoxDisplayAddCustomer.Text = "Please write the Name in the right format, which is letters only from A-Ö";
			}
			else if (!Regex.IsMatch(textBoxAddPhoneNumber.Text, "^[0-9]+$") || textBoxAddPhoneNumber.Text.Length != 10)
			{
				textBoxDisplayAddCustomer.Text = "Please write the Phone Number in the right format, which is with 10 digits";
			}
			else
			{
				try { 
			        string sSN = textBoxAddSsn.Text;
			        string name = textBoxAddName.Text;
			        string address = textBoxAddAddress.Text;
			        string phoneNumber = textBoxAddPhoneNumber.Text;

                    string query = sQL.InsertCustomer(sSN, name, address, phoneNumber);
					dAL.AlterDatabase(query);
                
                    this.AddToCustomerComboBox(sSN + " - " + name);
                    FormList.AccountForm.AddSSNToAccountComboBox(sSN + " - " + name);

                    textBoxAddSsn.Clear();
			        textBoxAddName.Clear();
			        textBoxAddAddress.Clear();
			        textBoxAddPhoneNumber.Clear();
				
			        textBoxDisplayAddCustomer.Text = name + " was added successfully";
				}
				catch (Exception ex)
				{
					string errorMessage = ExceptionHandler.HandleException(ex);					
					textBoxDisplayAddCustomer.Text = errorMessage;
				}
			}
        }

		// Method for removing a customer

		private void RemoveCustomer_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(comboBoxRemoveCustomer.Text))
            {
                textBoxDisplayRemoveCustomers.Text = "Please choose a customer you wish to remove.";
			}
            else
            {
                try
                {
                    string sSNName = comboBoxRemoveCustomer.SelectedItem.ToString();
                    string sSN = Utility.SplitMethod(sSNName);

                    string query = sQL.RemoveCustomer(sSN);
					dAL.AlterDatabase(query);

                    this.RemoveToCustomerComboBox(sSNName);
                    FormList.AccountForm.RemoveSSNFromAccountComboBox(sSNName);

                    textBoxDisplayRemoveCustomers.Text = sSN + " was removed successfully";
                }
                catch (Exception ex)
                {
                    string errorMessage = ExceptionHandler.HandleException(ex);
                    textBoxDisplayRemoveCustomers.Text = errorMessage;
                }
            }
        }

		// Method for updating a customers information

		private void UpdateCustomer_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(comboBoxUpdateCustomer.Text))
			{
				textBoxDisplayUpdateCustomer.Text = "Please choose a social security number.";
			}
			else if (string.IsNullOrEmpty(textBoxUpdateName.Text) || string.IsNullOrEmpty(textBoxUpdateAddress.Text) || string.IsNullOrEmpty(textBoxUpdatePhoneNumber.Text))
			{
				textBoxDisplayUpdateCustomer.Text = "You need to fill out the required fields, which is: name, address or phonenumber.";
			}
			else if (!Regex.IsMatch(textBoxUpdateName.Text, "(^[A-öa-ö]+)\\s*([A-Öa-ö]+)\\s*([A-Öa-ö]+$)"))
			{
				textBoxDisplayUpdateCustomer.Text = "Please write the Name in the right format, which is letters only from A-Ö";
			}
			else if (!Regex.IsMatch(textBoxUpdatePhoneNumber.Text, "^[0-9]+$") || textBoxUpdatePhoneNumber.Text.Length != 10)
			{
				textBoxDisplayUpdateCustomer.Text = "Please write the Phone Number in the right format, which is with 10 digits";
			}
			else
			{
				try
				{
					string sSNName = comboBoxUpdateCustomer.SelectedItem.ToString();
					string sSN = Utility.SplitMethod(sSNName);
					string name = textBoxUpdateName.Text;
					string address = textBoxUpdateAddress.Text;
					string phoneNumber = textBoxUpdatePhoneNumber.Text;

					RemoveToCustomerComboBox(sSNName);
					AddToCustomerComboBox(sSN + " - " + name);

					FormList.AccountForm.RemoveSSNFromAccountComboBox(sSNName);
					FormList.AccountForm.AddSSNToAccountComboBox(sSN + " - " + name);

					comboBoxUpdateCustomer.ResetText();
					textBoxUpdateName.Clear();
					textBoxUpdateAddress.Clear();
					textBoxUpdatePhoneNumber.Clear();

					string query = sQL.UpdateCustomer(sSN, name, address, phoneNumber);
					dAL.AlterDatabase(query);

					textBoxDisplayUpdateCustomer.Text = "Update was successfull."+ Environment.NewLine + "SSN: " + sSN + Environment.NewLine + "Name: " + name + Environment.NewLine + "Address: " + address + Environment.NewLine + "Phone number: " + phoneNumber;
				}
				catch(Exception ex)
				{
					string errorMessage = ExceptionHandler.HandleException(ex);
					textBoxDisplayUpdateCustomer.Text = errorMessage;

				}
			}
		}


		// Method for when clicking the Update customer comboboxes it fills out the information about the customer in the textboxes

        private void ComboBox_UpdateCustomer_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				string sSN = Utility.SplitMethod(comboBoxUpdateCustomer.SelectedItem.ToString());
				string query = sQL.GetCustomerQuery(sSN);
				DataTable dt = dAL.DataTableReturner(query);
				if (dt.Rows.Count > 0)
				{
					string name = dt.Rows[0]["name"].ToString();
					string address = dt.Rows[0]["address"].ToString();
					string phoneNumber = dt.Rows[0]["phoneNumber"].ToString();

					textBoxUpdateName.Text = name;
					textBoxUpdateAddress.Text = address;
					textBoxUpdatePhoneNumber.Text = phoneNumber;
				}
			}
			catch(Exception ex)
			{
				string errorMessage = ExceptionHandler.HandleException(ex);
				textBoxDisplayUpdateCustomer.Text = errorMessage;
			}		
		}
	}
}
