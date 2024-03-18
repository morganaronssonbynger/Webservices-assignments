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

namespace PA1
{
    public partial class Account : Form
    {
        DataAccessLayer dAL = new DataAccessLayer();
        SQLqueries sQL = new SQLqueries();

		// Default constructor for our Accountform, populates our comboboxes both with ssn - name and accountnumber - ssn

        public Account()
        {
			try
			{
				InitializeComponent();

                dataGridViewGetAccounts.AllowUserToAddRows = false;

                string queryGetCustomerSsn = sQL.GetSSNQuery();
				string queryGetAccountNumber = sQL.GetAccountNumberQuery();

				dAL.PopulateList(queryGetCustomerSsn);
				dAL.PopulateList(queryGetAccountNumber);
				foreach (string identifier in dAL.ComboBoxList)
				{
					if (identifier.Substring(0, 4).Equals("5535"))
					{
						this.AddAccountNumberToComboBox(identifier);
					}
					else
					{
						this.AddSSNToAccountComboBox(identifier);
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

		// Method for a button that switches to customer form

        private void SwitchToCustomerForm_Click(object sender, EventArgs e)
        {
            FormList.CustomerForm.Show();
            this.Hide();
        }

		// Method for adding ssn to our comboboxes

        public void AddSSNToAccountComboBox(string sSNName)
        {
			// Fixes duplicating bug in the comboboxes in the account form when creating a new customer and have not initialized the account form

            if (comboBoxAddAccount.Items.Contains(sSNName) || comboBoxGetAccounts.Items.Contains(sSNName))
            {

            }
            else
            {
                comboBoxAddAccount.Items.Add(sSNName);
                comboBoxGetAccounts.Items.Add(sSNName);
            }
        }

		// Method for removing ssn from our comboboxes

        public void RemoveSSNFromAccountComboBox(string sSNName)
        {
            comboBoxAddAccount.Items.Remove(sSNName);
            comboBoxGetAccounts.Items.Remove(sSNName);
        }

		// Method for adding accountnumber to our comboboxes

		public void AddAccountNumberToComboBox(string nr)
		{
			comboBoxRemoveAccount.Items.Add(nr);
			comboBoxDepositWithdraw.Items.Add(nr);
		}

		// Method for removing accountnumber from our comboboxes

		public void RemoveAccountNumberFromComboBox(string nr)
		{
			comboBoxRemoveAccount.Items.Remove(nr);
			comboBoxDepositWithdraw.Items.Remove(nr);
		}

		// Method that gets a specific customers accounts from the database and displays in datagridview

        private void GetAccounts_Click(object sender, EventArgs e)
        {
			if (string.IsNullOrEmpty(comboBoxGetAccounts.Text)) {
                string message = "Please choose a customer before searching";
                string title = "Error message";
                MessageBox.Show(message, title);
            }
			else
			{
				try
				{
					string sSN = Utility.SplitMethod(comboBoxGetAccounts.Text.ToString());
					string query = sQL.GetCustomersAccounts(sSN);
					dataGridViewGetAccounts.DataSource = dAL.DataTableReturner(query);
					comboBoxGetAccounts.Text = "";
				}
				catch(Exception ex)
				{
					string errorMessage = ExceptionHandler.HandleException(ex);
                    string title = "Error message";
                    MessageBox.Show(errorMessage, title);
                }						
			}
		}

		// Method for getting all the accounts in the database

		private void GetAllAccounts_Click(object sender, EventArgs e)
		{
			try
			{
				string query = sQL.GetAccountsQuery();
				dataGridViewGetAccounts.DataSource = dAL.DataTableReturner(query);
			}
			catch (Exception ex)
			{
				string errorMessage = ExceptionHandler.HandleException(ex);
				string title = "Error message";
				MessageBox.Show(errorMessage, title);
			}
		}

		// Method for adding a new account

		private void AddAccount_Click(object sender, EventArgs e)
        {
			if (string.IsNullOrEmpty(comboBoxAddAccount.Text))
            {
				textBoxDisplayAddAccount.Text = "Please choose a customer that you wish to create a new account for.";			
			} 
            else
            {
				try
				{
					string sSN = Utility.SplitMethod(comboBoxAddAccount.SelectedItem.ToString());

					Random random = new Random();
					int tmpAccountNumber = random.Next(10000, 99999);
					string fullAccountNumber = "5535" + tmpAccountNumber.ToString();

					string query = sQL.InsertAccount(fullAccountNumber, 0, sSN);
					dAL.AlterDatabase(query);

					textBoxDisplayAddAccount.Text = "You have successfully created an account for " + sSN + ", with accountnumber: \n" + fullAccountNumber;
					this.AddAccountNumberToComboBox(fullAccountNumber + " - " + sSN);
					comboBoxAddAccount.Text = "";
				}
				catch (Exception ex)
				{
					string errorMessage = ExceptionHandler.HandleException(ex);
					textBoxDisplayAddAccount.Text = errorMessage;
				}
			}
        }

		// Method for removing an account

        private void RemoveAccount_Click(object sender, EventArgs e)
        {

			if (string.IsNullOrEmpty(comboBoxRemoveAccount.Text))
            {
				textBoxDisplayRemoveAccount.Text = "Please choose an account that you wish to remove.";
            }
            else
            {
				try
				{
					string accountNumberSsn = comboBoxRemoveAccount.SelectedItem.ToString();
					string accountNumber = Utility.SplitMethod(accountNumberSsn);

					string query = sQL.RemoveAccount(accountNumber);
					dAL.AlterDatabase(query);
					this.RemoveAccountNumberFromComboBox(accountNumberSsn);

					textBoxDisplayRemoveAccount.Text = accountNumber + " was removed successfully";
				}
				catch (Exception ex)
				{
					string errorMessage = ExceptionHandler.HandleException(ex);
					textBoxDisplayRemoveAccount.Text = errorMessage;
				}
			}
		}

		// Method for depositing money to an account

		private void Deposit_Click(object sender, EventArgs e)
		{
			try
			{
				if (string.IsNullOrEmpty(comboBoxDepositWithdraw.Text))
				{
					textBoxDisplayDepositWindow.Text = "Please select an account that you wish to withdraw from or diposit to.";
				}
				else if (string.IsNullOrEmpty(textBoxDepositAmount.Text))
				{
					textBoxDisplayDepositWindow.Text = "Please write the amount you want to withdraw or dipsosit.";
				}
				else if(!Regex.IsMatch((textBoxDepositAmount.Text), "[0-9]+"))
				{
					textBoxDisplayDepositWindow.Text = "Please write the amount with digits.";
				}
				else if(Int32.Parse(textBoxDepositAmount.Text) <= 0)
				{
					textBoxDisplayDepositWindow.Text = "Please enter amount above 0 SEK.";
				}
				else
				{
					string accountNumber = Utility.SplitMethod(comboBoxDepositWithdraw.Text.ToString());
					string amount = textBoxDepositAmount.Text;
					int intAmount = int.Parse(amount);
					string query = sQL.DepositAmount(intAmount, accountNumber);
					dAL.AlterDatabase(query);

					textBoxDisplayDepositWindow.Text = intAmount + " SEK has been deposited to the account: " + accountNumber;
				}
			}
			catch (Exception ex)
			{
				string errorMessage = ExceptionHandler.HandleException(ex);
				textBoxDisplayDepositWindow.Text = errorMessage;
			}
		}

		// Method for withdrawing money from an account

		private void Withdraw_Click(object sender, EventArgs e)
		{
			try
			{
				if (comboBoxDepositWithdraw.SelectedItem == null)
				{
				textBoxDisplayDepositWindow.Text = "Please select an account that you wish to withdraw from or diposit to.";
				}
				else if (string.IsNullOrEmpty(textBoxDepositAmount.Text))
				{
					textBoxDisplayDepositWindow.Text = "Please write the amount you want to withdraw or dipsosit.";
				}
				else if (!Regex.IsMatch((textBoxDepositAmount.Text), "[0-9]+"))
				{
					textBoxDisplayDepositWindow.Text = "Please write the amount with digits.";
				}
				else if (Int32.Parse(textBoxDepositAmount.Text) <= 0)
				{
					textBoxDisplayDepositWindow.Text = "Please enter amount above 0 SEK";
				}
				else
				{
					string accountNumber = Utility.SplitMethod(comboBoxDepositWithdraw.Text.ToString());
					string amount = textBoxDepositAmount.Text;
					int intAmount = int.Parse(amount);

					string queryCheckBalance = sQL.CheckAmount(accountNumber);
					DataTable dT = dAL.DataTableReturner(queryCheckBalance);

					if ((int)dT.Rows[0]["balance"] < intAmount)
					{
						textBoxDisplayDepositWindow.Text = "The amount you want to withdraw exceeds your current balance, which is " + dT.Rows[0]["balance"].ToString() + " SEK";
					}
					else
					{
						string queryWithdraw = sQL.WithDrawAmount(intAmount, accountNumber);
						dAL.AlterDatabase(queryWithdraw);
						textBoxDisplayDepositWindow.Text = intAmount + " SEK has been withdrawn from the account " + accountNumber;
					}
				}
				
			}
			catch (Exception ex)
			{
				string errorMessage = ExceptionHandler.HandleException(ex);
				textBoxDisplayDepositWindow.Text = errorMessage;
			}
		}


		// Method for checking balance

		private void CheckBalance_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(comboBoxDepositWithdraw.Text))
			{
				textBoxDisplayDepositWindow.Text = "Please select an account before checking the balance.";
			}
			else
			{
				try
				{
					string accountNumber = Utility.SplitMethod(comboBoxDepositWithdraw.Text);
					string query = sQL.CheckAmount(accountNumber);
					DataTable dT = dAL.DataTableReturner(query);
					object balance = dT.Rows[0]["balance"];
					textBoxDisplayDepositWindow.Text = "The current balance for the account " + accountNumber + " is " + balance.ToString() + " SEK";
				}
				catch (Exception ex)
				{
					string errorMessage = ExceptionHandler.HandleException(ex);
					textBoxDisplayDepositWindow.Text = errorMessage;
				}				
			}			
		}
	}
}
