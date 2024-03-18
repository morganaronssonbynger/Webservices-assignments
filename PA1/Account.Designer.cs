using System.Windows.Forms;

namespace PA1
{
    partial class Account
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSwitchToCustomerForm = new System.Windows.Forms.Button();
            this.tabAccounts = new System.Windows.Forms.TabControl();
            this.tabPageAccountSearch = new System.Windows.Forms.TabPage();
            this.btnGetAllAccounts = new System.Windows.Forms.Button();
            this.labelAccountSearch = new System.Windows.Forms.Label();
            this.comboBoxGetAccounts = new System.Windows.Forms.ComboBox();
            this.dataGridViewGetAccounts = new System.Windows.Forms.DataGridView();
            this.btnGetAccounts = new System.Windows.Forms.Button();
            this.tabPageAccountAdd = new System.Windows.Forms.TabPage();
            this.textBoxDisplayAddAccount = new System.Windows.Forms.TextBox();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelAccountAdd = new System.Windows.Forms.Label();
            this.comboBoxAddAccount = new System.Windows.Forms.ComboBox();
            this.tabPageAccountRemove = new System.Windows.Forms.TabPage();
            this.labelAccountRemove = new System.Windows.Forms.Label();
            this.btnRemoveAccount = new System.Windows.Forms.Button();
            this.textBoxDisplayRemoveAccount = new System.Windows.Forms.TextBox();
            this.comboBoxRemoveAccount = new System.Windows.Forms.ComboBox();
            this.tabPageDepositAccount = new System.Windows.Forms.TabPage();
            this.btnCheckBalance = new System.Windows.Forms.Button();
            this.labelAmountDeposit = new System.Windows.Forms.Label();
            this.labelAccountDeposit = new System.Windows.Forms.Label();
            this.textBoxDisplayDepositWindow = new System.Windows.Forms.TextBox();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.textBoxDepositAmount = new System.Windows.Forms.TextBox();
            this.comboBoxDepositWithdraw = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAccount = new System.Windows.Forms.Label();
            this.tabAccounts.SuspendLayout();
            this.tabPageAccountSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGetAccounts)).BeginInit();
            this.tabPageAccountAdd.SuspendLayout();
            this.tabPageAccountRemove.SuspendLayout();
            this.tabPageDepositAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSwitchToCustomerForm
            // 
            this.btnSwitchToCustomerForm.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnSwitchToCustomerForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwitchToCustomerForm.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwitchToCustomerForm.ForeColor = System.Drawing.Color.White;
            this.btnSwitchToCustomerForm.Location = new System.Drawing.Point(1004, 48);
            this.btnSwitchToCustomerForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSwitchToCustomerForm.Name = "btnSwitchToCustomerForm";
            this.btnSwitchToCustomerForm.Size = new System.Drawing.Size(185, 47);
            this.btnSwitchToCustomerForm.TabIndex = 0;
            this.btnSwitchToCustomerForm.Text = "Go to customer";
            this.btnSwitchToCustomerForm.UseVisualStyleBackColor = true;
            this.btnSwitchToCustomerForm.Click += new System.EventHandler(this.SwitchToCustomerForm_Click);
            // 
            // tabAccounts
            // 
            this.tabAccounts.Controls.Add(this.tabPageAccountSearch);
            this.tabAccounts.Controls.Add(this.tabPageAccountAdd);
            this.tabAccounts.Controls.Add(this.tabPageAccountRemove);
            this.tabAccounts.Controls.Add(this.tabPageDepositAccount);
            this.tabAccounts.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabAccounts.ItemSize = new System.Drawing.Size(109, 21);
            this.tabAccounts.Location = new System.Drawing.Point(16, 100);
            this.tabAccounts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAccounts.Name = "tabAccounts";
            this.tabAccounts.SelectedIndex = 0;
            this.tabAccounts.Size = new System.Drawing.Size(1161, 530);
            this.tabAccounts.TabIndex = 1;
            // 
            // tabPageAccountSearch
            // 
            this.tabPageAccountSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageAccountSearch.Controls.Add(this.btnGetAllAccounts);
            this.tabPageAccountSearch.Controls.Add(this.labelAccountSearch);
            this.tabPageAccountSearch.Controls.Add(this.comboBoxGetAccounts);
            this.tabPageAccountSearch.Controls.Add(this.dataGridViewGetAccounts);
            this.tabPageAccountSearch.Controls.Add(this.btnGetAccounts);
            this.tabPageAccountSearch.Location = new System.Drawing.Point(4, 25);
            this.tabPageAccountSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageAccountSearch.Name = "tabPageAccountSearch";
            this.tabPageAccountSearch.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageAccountSearch.Size = new System.Drawing.Size(1153, 501);
            this.tabPageAccountSearch.TabIndex = 0;
            this.tabPageAccountSearch.Text = "         Search         ";
            // 
            // btnGetAllAccounts
            // 
            this.btnGetAllAccounts.Location = new System.Drawing.Point(128, 378);
            this.btnGetAllAccounts.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetAllAccounts.Name = "btnGetAllAccounts";
            this.btnGetAllAccounts.Size = new System.Drawing.Size(160, 35);
            this.btnGetAllAccounts.TabIndex = 4;
            this.btnGetAllAccounts.Text = "Get all accounts";
            this.btnGetAllAccounts.UseVisualStyleBackColor = true;
            this.btnGetAllAccounts.Click += new System.EventHandler(this.GetAllAccounts_Click);
            // 
            // labelAccountSearch
            // 
            this.labelAccountSearch.AutoSize = true;
            this.labelAccountSearch.Location = new System.Drawing.Point(50, 85);
            this.labelAccountSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAccountSearch.Name = "labelAccountSearch";
            this.labelAccountSearch.Size = new System.Drawing.Size(72, 17);
            this.labelAccountSearch.TabIndex = 3;
            this.labelAccountSearch.Text = "Customer:";
            // 
            // comboBoxGetAccounts
            // 
            this.comboBoxGetAccounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGetAccounts.FormattingEnabled = true;
            this.comboBoxGetAccounts.Location = new System.Drawing.Point(128, 82);
            this.comboBoxGetAccounts.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxGetAccounts.Name = "comboBoxGetAccounts";
            this.comboBoxGetAccounts.Size = new System.Drawing.Size(160, 24);
            this.comboBoxGetAccounts.TabIndex = 2;
            // 
            // dataGridViewGetAccounts
            // 
            this.dataGridViewGetAccounts.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewGetAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGetAccounts.Location = new System.Drawing.Point(331, 82);
            this.dataGridViewGetAccounts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewGetAccounts.Name = "dataGridViewGetAccounts";
            this.dataGridViewGetAccounts.RowTemplate.Height = 24;
            this.dataGridViewGetAccounts.Size = new System.Drawing.Size(494, 331);
            this.dataGridViewGetAccounts.TabIndex = 1;
            // 
            // btnGetAccounts
            // 
            this.btnGetAccounts.Location = new System.Drawing.Point(122, 140);
            this.btnGetAccounts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGetAccounts.Name = "btnGetAccounts";
            this.btnGetAccounts.Size = new System.Drawing.Size(160, 35);
            this.btnGetAccounts.TabIndex = 0;
            this.btnGetAccounts.Text = "Search";
            this.btnGetAccounts.UseVisualStyleBackColor = true;
            this.btnGetAccounts.Click += new System.EventHandler(this.GetAccounts_Click);
            // 
            // tabPageAccountAdd
            // 
            this.tabPageAccountAdd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageAccountAdd.Controls.Add(this.textBoxDisplayAddAccount);
            this.tabPageAccountAdd.Controls.Add(this.btnAddAccount);
            this.tabPageAccountAdd.Controls.Add(this.label2);
            this.tabPageAccountAdd.Controls.Add(this.labelAccountAdd);
            this.tabPageAccountAdd.Controls.Add(this.comboBoxAddAccount);
            this.tabPageAccountAdd.Location = new System.Drawing.Point(4, 25);
            this.tabPageAccountAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageAccountAdd.Name = "tabPageAccountAdd";
            this.tabPageAccountAdd.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageAccountAdd.Size = new System.Drawing.Size(1153, 501);
            this.tabPageAccountAdd.TabIndex = 1;
            this.tabPageAccountAdd.Text = "          Add          ";
            // 
            // textBoxDisplayAddAccount
            // 
            this.textBoxDisplayAddAccount.Location = new System.Drawing.Point(331, 82);
            this.textBoxDisplayAddAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDisplayAddAccount.Multiline = true;
            this.textBoxDisplayAddAccount.Name = "textBoxDisplayAddAccount";
            this.textBoxDisplayAddAccount.Size = new System.Drawing.Size(287, 153);
            this.textBoxDisplayAddAccount.TabIndex = 6;
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(122, 200);
            this.btnAddAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(166, 35);
            this.btnAddAccount.TabIndex = 5;
            this.btnAddAccount.Text = "Create new account";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.AddAccount_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 4;
            // 
            // labelAccountAdd
            // 
            this.labelAccountAdd.AutoSize = true;
            this.labelAccountAdd.Location = new System.Drawing.Point(50, 85);
            this.labelAccountAdd.Name = "labelAccountAdd";
            this.labelAccountAdd.Size = new System.Drawing.Size(72, 17);
            this.labelAccountAdd.TabIndex = 3;
            this.labelAccountAdd.Text = "Customer:";
            // 
            // comboBoxAddAccount
            // 
            this.comboBoxAddAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAddAccount.FormattingEnabled = true;
            this.comboBoxAddAccount.Location = new System.Drawing.Point(128, 82);
            this.comboBoxAddAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxAddAccount.Name = "comboBoxAddAccount";
            this.comboBoxAddAccount.Size = new System.Drawing.Size(160, 24);
            this.comboBoxAddAccount.TabIndex = 0;
            // 
            // tabPageAccountRemove
            // 
            this.tabPageAccountRemove.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageAccountRemove.Controls.Add(this.labelAccountRemove);
            this.tabPageAccountRemove.Controls.Add(this.btnRemoveAccount);
            this.tabPageAccountRemove.Controls.Add(this.textBoxDisplayRemoveAccount);
            this.tabPageAccountRemove.Controls.Add(this.comboBoxRemoveAccount);
            this.tabPageAccountRemove.Location = new System.Drawing.Point(4, 25);
            this.tabPageAccountRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageAccountRemove.Name = "tabPageAccountRemove";
            this.tabPageAccountRemove.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageAccountRemove.Size = new System.Drawing.Size(1153, 501);
            this.tabPageAccountRemove.TabIndex = 2;
            this.tabPageAccountRemove.Text = "         Remove        ";
            // 
            // labelAccountRemove
            // 
            this.labelAccountRemove.AutoSize = true;
            this.labelAccountRemove.Location = new System.Drawing.Point(50, 85);
            this.labelAccountRemove.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAccountRemove.Name = "labelAccountRemove";
            this.labelAccountRemove.Size = new System.Drawing.Size(63, 17);
            this.labelAccountRemove.TabIndex = 8;
            this.labelAccountRemove.Text = "Account:";
            // 
            // btnRemoveAccount
            // 
            this.btnRemoveAccount.Location = new System.Drawing.Point(122, 200);
            this.btnRemoveAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveAccount.Name = "btnRemoveAccount";
            this.btnRemoveAccount.Size = new System.Drawing.Size(166, 35);
            this.btnRemoveAccount.TabIndex = 2;
            this.btnRemoveAccount.Text = "Remove Account";
            this.btnRemoveAccount.UseVisualStyleBackColor = true;
            this.btnRemoveAccount.Click += new System.EventHandler(this.RemoveAccount_Click);
            // 
            // textBoxDisplayRemoveAccount
            // 
            this.textBoxDisplayRemoveAccount.Location = new System.Drawing.Point(331, 82);
            this.textBoxDisplayRemoveAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDisplayRemoveAccount.Multiline = true;
            this.textBoxDisplayRemoveAccount.Name = "textBoxDisplayRemoveAccount";
            this.textBoxDisplayRemoveAccount.Size = new System.Drawing.Size(287, 153);
            this.textBoxDisplayRemoveAccount.TabIndex = 7;
            // 
            // comboBoxRemoveAccount
            // 
            this.comboBoxRemoveAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRemoveAccount.FormattingEnabled = true;
            this.comboBoxRemoveAccount.Location = new System.Drawing.Point(128, 82);
            this.comboBoxRemoveAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxRemoveAccount.Name = "comboBoxRemoveAccount";
            this.comboBoxRemoveAccount.Size = new System.Drawing.Size(160, 24);
            this.comboBoxRemoveAccount.TabIndex = 1;
            // 
            // tabPageDepositAccount
            // 
            this.tabPageDepositAccount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageDepositAccount.Controls.Add(this.btnCheckBalance);
            this.tabPageDepositAccount.Controls.Add(this.labelAmountDeposit);
            this.tabPageDepositAccount.Controls.Add(this.labelAccountDeposit);
            this.tabPageDepositAccount.Controls.Add(this.textBoxDisplayDepositWindow);
            this.tabPageDepositAccount.Controls.Add(this.btnWithdraw);
            this.tabPageDepositAccount.Controls.Add(this.btnDeposit);
            this.tabPageDepositAccount.Controls.Add(this.textBoxDepositAmount);
            this.tabPageDepositAccount.Controls.Add(this.comboBoxDepositWithdraw);
            this.tabPageDepositAccount.Location = new System.Drawing.Point(4, 25);
            this.tabPageDepositAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageDepositAccount.Name = "tabPageDepositAccount";
            this.tabPageDepositAccount.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageDepositAccount.Size = new System.Drawing.Size(1153, 501);
            this.tabPageDepositAccount.TabIndex = 3;
            this.tabPageDepositAccount.Text = "  Deposit/Withdraw  ";
            // 
            // btnCheckBalance
            // 
            this.btnCheckBalance.Location = new System.Drawing.Point(335, 82);
            this.btnCheckBalance.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckBalance.Name = "btnCheckBalance";
            this.btnCheckBalance.Size = new System.Drawing.Size(123, 28);
            this.btnCheckBalance.TabIndex = 7;
            this.btnCheckBalance.Text = "Check balance";
            this.btnCheckBalance.UseVisualStyleBackColor = true;
            this.btnCheckBalance.Click += new System.EventHandler(this.CheckBalance_Click);
            // 
            // labelAmountDeposit
            // 
            this.labelAmountDeposit.AutoSize = true;
            this.labelAmountDeposit.Location = new System.Drawing.Point(50, 149);
            this.labelAmountDeposit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAmountDeposit.Name = "labelAmountDeposit";
            this.labelAmountDeposit.Size = new System.Drawing.Size(60, 17);
            this.labelAmountDeposit.TabIndex = 6;
            this.labelAmountDeposit.Text = "Amount:";
            // 
            // labelAccountDeposit
            // 
            this.labelAccountDeposit.AutoSize = true;
            this.labelAccountDeposit.Location = new System.Drawing.Point(50, 85);
            this.labelAccountDeposit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAccountDeposit.Name = "labelAccountDeposit";
            this.labelAccountDeposit.Size = new System.Drawing.Size(63, 17);
            this.labelAccountDeposit.TabIndex = 5;
            this.labelAccountDeposit.Text = "Account:";
            // 
            // textBoxDisplayDepositWindow
            // 
            this.textBoxDisplayDepositWindow.Location = new System.Drawing.Point(494, 78);
            this.textBoxDisplayDepositWindow.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDisplayDepositWindow.Multiline = true;
            this.textBoxDisplayDepositWindow.Name = "textBoxDisplayDepositWindow";
            this.textBoxDisplayDepositWindow.Size = new System.Drawing.Size(287, 153);
            this.textBoxDisplayDepositWindow.TabIndex = 4;
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(226, 203);
            this.btnWithdraw.Margin = new System.Windows.Forms.Padding(4);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(100, 28);
            this.btnWithdraw.TabIndex = 3;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.Withdraw_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(90, 203);
            this.btnDeposit.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(100, 28);
            this.btnDeposit.TabIndex = 2;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.Deposit_Click);
            // 
            // textBoxDepositAmount
            // 
            this.textBoxDepositAmount.Location = new System.Drawing.Point(128, 149);
            this.textBoxDepositAmount.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDepositAmount.Name = "textBoxDepositAmount";
            this.textBoxDepositAmount.Size = new System.Drawing.Size(160, 22);
            this.textBoxDepositAmount.TabIndex = 1;
            // 
            // comboBoxDepositWithdraw
            // 
            this.comboBoxDepositWithdraw.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDepositWithdraw.FormattingEnabled = true;
            this.comboBoxDepositWithdraw.Location = new System.Drawing.Point(128, 82);
            this.comboBoxDepositWithdraw.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxDepositWithdraw.Name = "comboBoxDepositWithdraw";
            this.comboBoxDepositWithdraw.Size = new System.Drawing.Size(160, 24);
            this.comboBoxDepositWithdraw.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1000, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kritaen5a Bank";
            // 
            // labelAccount
            // 
            this.labelAccount.AutoSize = true;
            this.labelAccount.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAccount.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelAccount.Location = new System.Drawing.Point(523, 33);
            this.labelAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAccount.Name = "labelAccount";
            this.labelAccount.Size = new System.Drawing.Size(155, 41);
            this.labelAccount.TabIndex = 4;
            this.labelAccount.Text = "Account";
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1191, 641);
            this.Controls.Add(this.labelAccount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabAccounts);
            this.Controls.Add(this.btnSwitchToCustomerForm);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Account";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account";
            this.tabAccounts.ResumeLayout(false);
            this.tabPageAccountSearch.ResumeLayout(false);
            this.tabPageAccountSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGetAccounts)).EndInit();
            this.tabPageAccountAdd.ResumeLayout(false);
            this.tabPageAccountAdd.PerformLayout();
            this.tabPageAccountRemove.ResumeLayout(false);
            this.tabPageAccountRemove.PerformLayout();
            this.tabPageDepositAccount.ResumeLayout(false);
            this.tabPageDepositAccount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSwitchToCustomerForm;
        private System.Windows.Forms.TabControl tabAccounts;
        private System.Windows.Forms.TabPage tabPageAccountSearch;
        private System.Windows.Forms.TabPage tabPageAccountAdd;
        private System.Windows.Forms.DataGridView dataGridViewGetAccounts;
        private System.Windows.Forms.Button btnGetAccounts;
        private System.Windows.Forms.ComboBox comboBoxAddAccount;
        private System.Windows.Forms.Label labelAccountAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.TextBox textBoxDisplayAddAccount;
        private System.Windows.Forms.TabPage tabPageAccountRemove;
        private System.Windows.Forms.TabPage tabPageDepositAccount;
        private System.Windows.Forms.ComboBox comboBoxRemoveAccount;
        private System.Windows.Forms.TextBox textBoxDisplayRemoveAccount;
        private System.Windows.Forms.Button btnRemoveAccount;
        private System.Windows.Forms.ComboBox comboBoxGetAccounts;
        private System.Windows.Forms.Label labelAccountSearch;
        private System.Windows.Forms.TextBox textBoxDisplayDepositWindow;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.TextBox textBoxDepositAmount;
        private System.Windows.Forms.ComboBox comboBoxDepositWithdraw;
        private System.Windows.Forms.Label labelAmountDeposit;
        private System.Windows.Forms.Label labelAccountDeposit;
		private Button btnGetAllAccounts;
        private Label labelAccountRemove;
		private Button btnCheckBalance;
		private Label label1;
		private Label labelAccount;
	}
}