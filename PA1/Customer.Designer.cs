namespace PA1
{
    partial class Customer
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
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.dataGridViewSearchCustomers = new System.Windows.Forms.DataGridView();
            this.tabCustomers = new System.Windows.Forms.TabControl();
            this.tabPageCustomerSearch = new System.Windows.Forms.TabPage();
            this.btnGetAllCustomers = new System.Windows.Forms.Button();
            this.labelSsnSearch = new System.Windows.Forms.Label();
            this.comboBoxSearchCustomers = new System.Windows.Forms.ComboBox();
            this.tabPageCustomerAdd = new System.Windows.Forms.TabPage();
            this.labelPhoneNumberFormat = new System.Windows.Forms.Label();
            this.labelAddressFormat = new System.Windows.Forms.Label();
            this.labelNameFormat = new System.Windows.Forms.Label();
            this.labelSSnFormat = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxDisplayAddCustomer = new System.Windows.Forms.TextBox();
            this.textBoxAddPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxAddAddress = new System.Windows.Forms.TextBox();
            this.textBoxAddName = new System.Windows.Forms.TextBox();
            this.textBoxAddSsn = new System.Windows.Forms.TextBox();
            this.btnAddCustomers = new System.Windows.Forms.Button();
            this.labelAddPhoneNumber = new System.Windows.Forms.Label();
            this.labelAddAddress = new System.Windows.Forms.Label();
            this.labelAddName = new System.Windows.Forms.Label();
            this.labelAddSsn = new System.Windows.Forms.Label();
            this.tabPageCustomerRemove = new System.Windows.Forms.TabPage();
            this.labelSSNRemoveCustomer = new System.Windows.Forms.Label();
            this.textBoxDisplayRemoveCustomers = new System.Windows.Forms.TextBox();
            this.comboBoxRemoveCustomer = new System.Windows.Forms.ComboBox();
            this.btnRemoveCustomers = new System.Windows.Forms.Button();
            this.tabPageCustomerUpdate = new System.Windows.Forms.TabPage();
            this.labelUpdatePhoneNumberFormat = new System.Windows.Forms.Label();
            this.labelUpdateAddressFormat = new System.Windows.Forms.Label();
            this.labelUpdateSsnFormat = new System.Windows.Forms.Label();
            this.UpdateCustomer = new System.Windows.Forms.Button();
            this.textBoxDisplayUpdateCustomer = new System.Windows.Forms.TextBox();
            this.labelUpdatePhoneNumber = new System.Windows.Forms.Label();
            this.labelUpdateAddress = new System.Windows.Forms.Label();
            this.labelUpdateName = new System.Windows.Forms.Label();
            this.labelUpdateSSN = new System.Windows.Forms.Label();
            this.textBoxUpdatePhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxUpdateAddress = new System.Windows.Forms.TextBox();
            this.textBoxUpdateName = new System.Windows.Forms.TextBox();
            this.comboBoxUpdateCustomer = new System.Windows.Forms.ComboBox();
            this.btnSwitchToAccountForm = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCustomer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchCustomers)).BeginInit();
            this.tabCustomers.SuspendLayout();
            this.tabPageCustomerSearch.SuspendLayout();
            this.tabPageCustomerAdd.SuspendLayout();
            this.tabPageCustomerRemove.SuspendLayout();
            this.tabPageCustomerUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.Location = new System.Drawing.Point(123, 140);
            this.btnSearchCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(160, 34);
            this.btnSearchCustomer.TabIndex = 0;
            this.btnSearchCustomer.Text = "Search";
            this.btnSearchCustomer.UseVisualStyleBackColor = true;
            this.btnSearchCustomer.Click += new System.EventHandler(this.GetCustomer_Click);
            // 
            // dataGridViewSearchCustomers
            // 
            this.dataGridViewSearchCustomers.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewSearchCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearchCustomers.Location = new System.Drawing.Point(365, 82);
            this.dataGridViewSearchCustomers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewSearchCustomers.Name = "dataGridViewSearchCustomers";
            this.dataGridViewSearchCustomers.RowTemplate.Height = 24;
            this.dataGridViewSearchCustomers.Size = new System.Drawing.Size(595, 331);
            this.dataGridViewSearchCustomers.TabIndex = 1;
            // 
            // tabCustomers
            // 
            this.tabCustomers.Controls.Add(this.tabPageCustomerSearch);
            this.tabCustomers.Controls.Add(this.tabPageCustomerAdd);
            this.tabCustomers.Controls.Add(this.tabPageCustomerRemove);
            this.tabCustomers.Controls.Add(this.tabPageCustomerUpdate);
            this.tabCustomers.ItemSize = new System.Drawing.Size(109, 21);
            this.tabCustomers.Location = new System.Drawing.Point(16, 100);
            this.tabCustomers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCustomers.Name = "tabCustomers";
            this.tabCustomers.SelectedIndex = 0;
            this.tabCustomers.Size = new System.Drawing.Size(1161, 530);
            this.tabCustomers.TabIndex = 2;
            // 
            // tabPageCustomerSearch
            // 
            this.tabPageCustomerSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageCustomerSearch.Controls.Add(this.btnGetAllCustomers);
            this.tabPageCustomerSearch.Controls.Add(this.labelSsnSearch);
            this.tabPageCustomerSearch.Controls.Add(this.comboBoxSearchCustomers);
            this.tabPageCustomerSearch.Controls.Add(this.btnSearchCustomer);
            this.tabPageCustomerSearch.Controls.Add(this.dataGridViewSearchCustomers);
            this.tabPageCustomerSearch.Location = new System.Drawing.Point(4, 25);
            this.tabPageCustomerSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageCustomerSearch.Name = "tabPageCustomerSearch";
            this.tabPageCustomerSearch.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageCustomerSearch.Size = new System.Drawing.Size(1153, 501);
            this.tabPageCustomerSearch.TabIndex = 0;
            this.tabPageCustomerSearch.Text = "         Search         ";
            // 
            // btnGetAllCustomers
            // 
            this.btnGetAllCustomers.Location = new System.Drawing.Point(128, 378);
            this.btnGetAllCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetAllCustomers.Name = "btnGetAllCustomers";
            this.btnGetAllCustomers.Size = new System.Drawing.Size(160, 34);
            this.btnGetAllCustomers.TabIndex = 4;
            this.btnGetAllCustomers.Text = "Get all customers";
            this.btnGetAllCustomers.UseVisualStyleBackColor = true;
            this.btnGetAllCustomers.Click += new System.EventHandler(this.GetAllCustomers_Click);
            // 
            // labelSsnSearch
            // 
            this.labelSsnSearch.AutoSize = true;
            this.labelSsnSearch.Location = new System.Drawing.Point(51, 85);
            this.labelSsnSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSsnSearch.Name = "labelSsnSearch";
            this.labelSsnSearch.Size = new System.Drawing.Size(40, 17);
            this.labelSsnSearch.TabIndex = 3;
            this.labelSsnSearch.Text = "SSN:";
            // 
            // comboBoxSearchCustomers
            // 
            this.comboBoxSearchCustomers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchCustomers.FormattingEnabled = true;
            this.comboBoxSearchCustomers.Location = new System.Drawing.Point(120, 82);
            this.comboBoxSearchCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSearchCustomers.Name = "comboBoxSearchCustomers";
            this.comboBoxSearchCustomers.Size = new System.Drawing.Size(160, 24);
            this.comboBoxSearchCustomers.TabIndex = 2;
            // 
            // tabPageCustomerAdd
            // 
            this.tabPageCustomerAdd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageCustomerAdd.Controls.Add(this.labelPhoneNumberFormat);
            this.tabPageCustomerAdd.Controls.Add(this.labelAddressFormat);
            this.tabPageCustomerAdd.Controls.Add(this.labelNameFormat);
            this.tabPageCustomerAdd.Controls.Add(this.labelSSnFormat);
            this.tabPageCustomerAdd.Controls.Add(this.label9);
            this.tabPageCustomerAdd.Controls.Add(this.label8);
            this.tabPageCustomerAdd.Controls.Add(this.label7);
            this.tabPageCustomerAdd.Controls.Add(this.textBoxDisplayAddCustomer);
            this.tabPageCustomerAdd.Controls.Add(this.textBoxAddPhoneNumber);
            this.tabPageCustomerAdd.Controls.Add(this.textBoxAddAddress);
            this.tabPageCustomerAdd.Controls.Add(this.textBoxAddName);
            this.tabPageCustomerAdd.Controls.Add(this.textBoxAddSsn);
            this.tabPageCustomerAdd.Controls.Add(this.btnAddCustomers);
            this.tabPageCustomerAdd.Controls.Add(this.labelAddPhoneNumber);
            this.tabPageCustomerAdd.Controls.Add(this.labelAddAddress);
            this.tabPageCustomerAdd.Controls.Add(this.labelAddName);
            this.tabPageCustomerAdd.Controls.Add(this.labelAddSsn);
            this.tabPageCustomerAdd.Location = new System.Drawing.Point(4, 25);
            this.tabPageCustomerAdd.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageCustomerAdd.Name = "tabPageCustomerAdd";
            this.tabPageCustomerAdd.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageCustomerAdd.Size = new System.Drawing.Size(1153, 501);
            this.tabPageCustomerAdd.TabIndex = 1;
            this.tabPageCustomerAdd.Text = "          Add          ";
            // 
            // labelPhoneNumberFormat
            // 
            this.labelPhoneNumberFormat.AutoSize = true;
            this.labelPhoneNumberFormat.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelPhoneNumberFormat.Location = new System.Drawing.Point(258, 188);
            this.labelPhoneNumberFormat.Name = "labelPhoneNumberFormat";
            this.labelPhoneNumberFormat.Size = new System.Drawing.Size(101, 17);
            this.labelPhoneNumberFormat.TabIndex = 20;
            this.labelPhoneNumberFormat.Text = "07XXXXXXXX*";
            // 
            // labelAddressFormat
            // 
            this.labelAddressFormat.AutoSize = true;
            this.labelAddressFormat.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelAddressFormat.Location = new System.Drawing.Point(257, 153);
            this.labelAddressFormat.Name = "labelAddressFormat";
            this.labelAddressFormat.Size = new System.Drawing.Size(99, 17);
            this.labelAddressFormat.TabIndex = 19;
            this.labelAddressFormat.Text = "Streetname X*";
            // 
            // labelNameFormat
            // 
            this.labelNameFormat.AutoSize = true;
            this.labelNameFormat.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelNameFormat.Location = new System.Drawing.Point(258, 117);
            this.labelNameFormat.Name = "labelNameFormat";
            this.labelNameFormat.Size = new System.Drawing.Size(74, 17);
            this.labelNameFormat.TabIndex = 18;
            this.labelNameFormat.Text = "John Doe*";
            // 
            // labelSSnFormat
            // 
            this.labelSSnFormat.AutoSize = true;
            this.labelSSnFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSSnFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSSnFormat.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelSSnFormat.Location = new System.Drawing.Point(258, 87);
            this.labelSSnFormat.Name = "labelSSnFormat";
            this.labelSSnFormat.Size = new System.Drawing.Size(87, 13);
            this.labelSSnFormat.TabIndex = 17;
            this.labelSSnFormat.Text = "YYDDMMXXXX*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(213, 82);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 17);
            this.label9.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(117, 59);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 17);
            this.label8.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(128, 59);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 17);
            this.label7.TabIndex = 14;
            // 
            // textBoxDisplayAddCustomer
            // 
            this.textBoxDisplayAddCustomer.Location = new System.Drawing.Point(365, 82);
            this.textBoxDisplayAddCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDisplayAddCustomer.Multiline = true;
            this.textBoxDisplayAddCustomer.Name = "textBoxDisplayAddCustomer";
            this.textBoxDisplayAddCustomer.ReadOnly = true;
            this.textBoxDisplayAddCustomer.Size = new System.Drawing.Size(287, 180);
            this.textBoxDisplayAddCustomer.TabIndex = 13;
            // 
            // textBoxAddPhoneNumber
            // 
            this.textBoxAddPhoneNumber.Location = new System.Drawing.Point(120, 185);
            this.textBoxAddPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAddPhoneNumber.Name = "textBoxAddPhoneNumber";
            this.textBoxAddPhoneNumber.Size = new System.Drawing.Size(132, 22);
            this.textBoxAddPhoneNumber.TabIndex = 12;
            // 
            // textBoxAddAddress
            // 
            this.textBoxAddAddress.Location = new System.Drawing.Point(120, 150);
            this.textBoxAddAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAddAddress.Name = "textBoxAddAddress";
            this.textBoxAddAddress.Size = new System.Drawing.Size(132, 22);
            this.textBoxAddAddress.TabIndex = 11;
            // 
            // textBoxAddName
            // 
            this.textBoxAddName.Location = new System.Drawing.Point(120, 117);
            this.textBoxAddName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAddName.Name = "textBoxAddName";
            this.textBoxAddName.Size = new System.Drawing.Size(132, 22);
            this.textBoxAddName.TabIndex = 10;
            // 
            // textBoxAddSsn
            // 
            this.textBoxAddSsn.Location = new System.Drawing.Point(120, 82);
            this.textBoxAddSsn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAddSsn.Name = "textBoxAddSsn";
            this.textBoxAddSsn.Size = new System.Drawing.Size(132, 22);
            this.textBoxAddSsn.TabIndex = 9;
            // 
            // btnAddCustomers
            // 
            this.btnAddCustomers.Location = new System.Drawing.Point(120, 234);
            this.btnAddCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddCustomers.Name = "btnAddCustomers";
            this.btnAddCustomers.Size = new System.Drawing.Size(132, 28);
            this.btnAddCustomers.TabIndex = 8;
            this.btnAddCustomers.Text = "Add";
            this.btnAddCustomers.UseVisualStyleBackColor = true;
            this.btnAddCustomers.Click += new System.EventHandler(this.AddCustomer_Click);
            // 
            // labelAddPhoneNumber
            // 
            this.labelAddPhoneNumber.AutoSize = true;
            this.labelAddPhoneNumber.Location = new System.Drawing.Point(8, 187);
            this.labelAddPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAddPhoneNumber.Name = "labelAddPhoneNumber";
            this.labelAddPhoneNumber.Size = new System.Drawing.Size(110, 17);
            this.labelAddPhoneNumber.TabIndex = 3;
            this.labelAddPhoneNumber.Text = "Phone number:*";
            // 
            // labelAddAddress
            // 
            this.labelAddAddress.AutoSize = true;
            this.labelAddAddress.Location = new System.Drawing.Point(27, 153);
            this.labelAddAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAddAddress.Name = "labelAddAddress";
            this.labelAddAddress.Size = new System.Drawing.Size(69, 17);
            this.labelAddAddress.TabIndex = 2;
            this.labelAddAddress.Text = "Address:*";
            // 
            // labelAddName
            // 
            this.labelAddName.AutoSize = true;
            this.labelAddName.Location = new System.Drawing.Point(41, 117);
            this.labelAddName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAddName.Name = "labelAddName";
            this.labelAddName.Size = new System.Drawing.Size(54, 17);
            this.labelAddName.TabIndex = 1;
            this.labelAddName.Text = "Name:*";
            // 
            // labelAddSsn
            // 
            this.labelAddSsn.AutoSize = true;
            this.labelAddSsn.Location = new System.Drawing.Point(51, 85);
            this.labelAddSsn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAddSsn.Name = "labelAddSsn";
            this.labelAddSsn.Size = new System.Drawing.Size(45, 17);
            this.labelAddSsn.TabIndex = 0;
            this.labelAddSsn.Text = "SSN:*";
            // 
            // tabPageCustomerRemove
            // 
            this.tabPageCustomerRemove.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageCustomerRemove.Controls.Add(this.labelSSNRemoveCustomer);
            this.tabPageCustomerRemove.Controls.Add(this.textBoxDisplayRemoveCustomers);
            this.tabPageCustomerRemove.Controls.Add(this.comboBoxRemoveCustomer);
            this.tabPageCustomerRemove.Controls.Add(this.btnRemoveCustomers);
            this.tabPageCustomerRemove.Location = new System.Drawing.Point(4, 25);
            this.tabPageCustomerRemove.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageCustomerRemove.Name = "tabPageCustomerRemove";
            this.tabPageCustomerRemove.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageCustomerRemove.Size = new System.Drawing.Size(1153, 501);
            this.tabPageCustomerRemove.TabIndex = 2;
            this.tabPageCustomerRemove.Text = "         Remove        ";
            // 
            // labelSSNRemoveCustomer
            // 
            this.labelSSNRemoveCustomer.AutoSize = true;
            this.labelSSNRemoveCustomer.Location = new System.Drawing.Point(51, 85);
            this.labelSSNRemoveCustomer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSSNRemoveCustomer.Name = "labelSSNRemoveCustomer";
            this.labelSSNRemoveCustomer.Size = new System.Drawing.Size(40, 17);
            this.labelSSNRemoveCustomer.TabIndex = 15;
            this.labelSSNRemoveCustomer.Text = "SSN:";
            // 
            // textBoxDisplayRemoveCustomers
            // 
            this.textBoxDisplayRemoveCustomers.Location = new System.Drawing.Point(365, 82);
            this.textBoxDisplayRemoveCustomers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDisplayRemoveCustomers.Multiline = true;
            this.textBoxDisplayRemoveCustomers.Name = "textBoxDisplayRemoveCustomers";
            this.textBoxDisplayRemoveCustomers.ReadOnly = true;
            this.textBoxDisplayRemoveCustomers.Size = new System.Drawing.Size(287, 180);
            this.textBoxDisplayRemoveCustomers.TabIndex = 14;
            // 
            // comboBoxRemoveCustomer
            // 
            this.comboBoxRemoveCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRemoveCustomer.FormattingEnabled = true;
            this.comboBoxRemoveCustomer.Location = new System.Drawing.Point(120, 82);
            this.comboBoxRemoveCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxRemoveCustomer.Name = "comboBoxRemoveCustomer";
            this.comboBoxRemoveCustomer.Size = new System.Drawing.Size(160, 24);
            this.comboBoxRemoveCustomer.TabIndex = 1;
            // 
            // btnRemoveCustomers
            // 
            this.btnRemoveCustomers.Location = new System.Drawing.Point(120, 226);
            this.btnRemoveCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveCustomers.Name = "btnRemoveCustomers";
            this.btnRemoveCustomers.Size = new System.Drawing.Size(160, 34);
            this.btnRemoveCustomers.TabIndex = 0;
            this.btnRemoveCustomers.Text = "Remove customer";
            this.btnRemoveCustomers.UseVisualStyleBackColor = true;
            this.btnRemoveCustomers.Click += new System.EventHandler(this.RemoveCustomer_Click);
            // 
            // tabPageCustomerUpdate
            // 
            this.tabPageCustomerUpdate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageCustomerUpdate.Controls.Add(this.labelUpdatePhoneNumberFormat);
            this.tabPageCustomerUpdate.Controls.Add(this.labelUpdateAddressFormat);
            this.tabPageCustomerUpdate.Controls.Add(this.labelUpdateSsnFormat);
            this.tabPageCustomerUpdate.Controls.Add(this.UpdateCustomer);
            this.tabPageCustomerUpdate.Controls.Add(this.textBoxDisplayUpdateCustomer);
            this.tabPageCustomerUpdate.Controls.Add(this.labelUpdatePhoneNumber);
            this.tabPageCustomerUpdate.Controls.Add(this.labelUpdateAddress);
            this.tabPageCustomerUpdate.Controls.Add(this.labelUpdateName);
            this.tabPageCustomerUpdate.Controls.Add(this.labelUpdateSSN);
            this.tabPageCustomerUpdate.Controls.Add(this.textBoxUpdatePhoneNumber);
            this.tabPageCustomerUpdate.Controls.Add(this.textBoxUpdateAddress);
            this.tabPageCustomerUpdate.Controls.Add(this.textBoxUpdateName);
            this.tabPageCustomerUpdate.Controls.Add(this.comboBoxUpdateCustomer);
            this.tabPageCustomerUpdate.Location = new System.Drawing.Point(4, 25);
            this.tabPageCustomerUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageCustomerUpdate.Name = "tabPageCustomerUpdate";
            this.tabPageCustomerUpdate.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageCustomerUpdate.Size = new System.Drawing.Size(1153, 501);
            this.tabPageCustomerUpdate.TabIndex = 3;
            this.tabPageCustomerUpdate.Text = "           Update          ";
            // 
            // labelUpdatePhoneNumberFormat
            // 
            this.labelUpdatePhoneNumberFormat.AutoSize = true;
            this.labelUpdatePhoneNumberFormat.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelUpdatePhoneNumberFormat.Location = new System.Drawing.Point(258, 188);
            this.labelUpdatePhoneNumberFormat.Name = "labelUpdatePhoneNumberFormat";
            this.labelUpdatePhoneNumberFormat.Size = new System.Drawing.Size(101, 17);
            this.labelUpdatePhoneNumberFormat.TabIndex = 21;
            this.labelUpdatePhoneNumberFormat.Text = "07XXXXXXXX*";
            // 
            // labelUpdateAddressFormat
            // 
            this.labelUpdateAddressFormat.AutoSize = true;
            this.labelUpdateAddressFormat.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelUpdateAddressFormat.Location = new System.Drawing.Point(257, 153);
            this.labelUpdateAddressFormat.Name = "labelUpdateAddressFormat";
            this.labelUpdateAddressFormat.Size = new System.Drawing.Size(99, 17);
            this.labelUpdateAddressFormat.TabIndex = 20;
            this.labelUpdateAddressFormat.Text = "Streetname X*";
            // 
            // labelUpdateSsnFormat
            // 
            this.labelUpdateSsnFormat.AutoSize = true;
            this.labelUpdateSsnFormat.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelUpdateSsnFormat.Location = new System.Drawing.Point(258, 117);
            this.labelUpdateSsnFormat.Name = "labelUpdateSsnFormat";
            this.labelUpdateSsnFormat.Size = new System.Drawing.Size(74, 17);
            this.labelUpdateSsnFormat.TabIndex = 19;
            this.labelUpdateSsnFormat.Text = "John Doe*";
            // 
            // UpdateCustomer
            // 
            this.UpdateCustomer.Location = new System.Drawing.Point(120, 234);
            this.UpdateCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateCustomer.Name = "UpdateCustomer";
            this.UpdateCustomer.Size = new System.Drawing.Size(132, 28);
            this.UpdateCustomer.TabIndex = 9;
            this.UpdateCustomer.Text = "Update";
            this.UpdateCustomer.UseVisualStyleBackColor = true;
            this.UpdateCustomer.Click += new System.EventHandler(this.UpdateCustomer_Click);
            // 
            // textBoxDisplayUpdateCustomer
            // 
            this.textBoxDisplayUpdateCustomer.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxDisplayUpdateCustomer.Location = new System.Drawing.Point(365, 82);
            this.textBoxDisplayUpdateCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDisplayUpdateCustomer.Multiline = true;
            this.textBoxDisplayUpdateCustomer.Name = "textBoxDisplayUpdateCustomer";
            this.textBoxDisplayUpdateCustomer.Size = new System.Drawing.Size(287, 180);
            this.textBoxDisplayUpdateCustomer.TabIndex = 8;
            // 
            // labelUpdatePhoneNumber
            // 
            this.labelUpdatePhoneNumber.AutoSize = true;
            this.labelUpdatePhoneNumber.Location = new System.Drawing.Point(8, 187);
            this.labelUpdatePhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUpdatePhoneNumber.Name = "labelUpdatePhoneNumber";
            this.labelUpdatePhoneNumber.Size = new System.Drawing.Size(110, 17);
            this.labelUpdatePhoneNumber.TabIndex = 7;
            this.labelUpdatePhoneNumber.Text = "Phone number:*";
            // 
            // labelUpdateAddress
            // 
            this.labelUpdateAddress.AutoSize = true;
            this.labelUpdateAddress.Location = new System.Drawing.Point(27, 153);
            this.labelUpdateAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUpdateAddress.Name = "labelUpdateAddress";
            this.labelUpdateAddress.Size = new System.Drawing.Size(69, 17);
            this.labelUpdateAddress.TabIndex = 6;
            this.labelUpdateAddress.Text = "Address:*";
            // 
            // labelUpdateName
            // 
            this.labelUpdateName.AutoSize = true;
            this.labelUpdateName.Location = new System.Drawing.Point(41, 117);
            this.labelUpdateName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUpdateName.Name = "labelUpdateName";
            this.labelUpdateName.Size = new System.Drawing.Size(54, 17);
            this.labelUpdateName.TabIndex = 5;
            this.labelUpdateName.Text = "Name:*";
            // 
            // labelUpdateSSN
            // 
            this.labelUpdateSSN.AutoSize = true;
            this.labelUpdateSSN.Location = new System.Drawing.Point(51, 85);
            this.labelUpdateSSN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUpdateSSN.Name = "labelUpdateSSN";
            this.labelUpdateSSN.Size = new System.Drawing.Size(45, 17);
            this.labelUpdateSSN.TabIndex = 4;
            this.labelUpdateSSN.Text = "SSN:*";
            // 
            // textBoxUpdatePhoneNumber
            // 
            this.textBoxUpdatePhoneNumber.Location = new System.Drawing.Point(120, 185);
            this.textBoxUpdatePhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUpdatePhoneNumber.Name = "textBoxUpdatePhoneNumber";
            this.textBoxUpdatePhoneNumber.Size = new System.Drawing.Size(132, 22);
            this.textBoxUpdatePhoneNumber.TabIndex = 3;
            // 
            // textBoxUpdateAddress
            // 
            this.textBoxUpdateAddress.Location = new System.Drawing.Point(120, 150);
            this.textBoxUpdateAddress.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUpdateAddress.Name = "textBoxUpdateAddress";
            this.textBoxUpdateAddress.Size = new System.Drawing.Size(132, 22);
            this.textBoxUpdateAddress.TabIndex = 2;
            // 
            // textBoxUpdateName
            // 
            this.textBoxUpdateName.Location = new System.Drawing.Point(120, 117);
            this.textBoxUpdateName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUpdateName.Name = "textBoxUpdateName";
            this.textBoxUpdateName.Size = new System.Drawing.Size(132, 22);
            this.textBoxUpdateName.TabIndex = 1;
            // 
            // comboBoxUpdateCustomer
            // 
            this.comboBoxUpdateCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUpdateCustomer.FormattingEnabled = true;
            this.comboBoxUpdateCustomer.Location = new System.Drawing.Point(120, 82);
            this.comboBoxUpdateCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxUpdateCustomer.Name = "comboBoxUpdateCustomer";
            this.comboBoxUpdateCustomer.Size = new System.Drawing.Size(160, 24);
            this.comboBoxUpdateCustomer.TabIndex = 0;
            this.comboBoxUpdateCustomer.SelectedIndexChanged += new System.EventHandler(this.ComboBox_UpdateCustomer_SelectedIndexChanged);
            // 
            // btnSwitchToAccountForm
            // 
            this.btnSwitchToAccountForm.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSwitchToAccountForm.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnSwitchToAccountForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwitchToAccountForm.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwitchToAccountForm.ForeColor = System.Drawing.Color.White;
            this.btnSwitchToAccountForm.Location = new System.Drawing.Point(1004, 48);
            this.btnSwitchToAccountForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSwitchToAccountForm.Name = "btnSwitchToAccountForm";
            this.btnSwitchToAccountForm.Size = new System.Drawing.Size(185, 47);
            this.btnSwitchToAccountForm.TabIndex = 6;
            this.btnSwitchToAccountForm.Text = "Go to account";
            this.btnSwitchToAccountForm.UseVisualStyleBackColor = false;
            this.btnSwitchToAccountForm.Click += new System.EventHandler(this.SwitchToAccountForm_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 0;
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
            this.label1.TabIndex = 7;
            this.label1.Text = "Kritaen5a Bank";
            // 
            // labelCustomer
            // 
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelCustomer.Location = new System.Drawing.Point(523, 33);
            this.labelCustomer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(184, 41);
            this.labelCustomer.TabIndex = 8;
            this.labelCustomer.Text = "Customer";
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1191, 641);
            this.Controls.Add(this.labelCustomer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabCustomers);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSwitchToAccountForm);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchCustomers)).EndInit();
            this.tabCustomers.ResumeLayout(false);
            this.tabPageCustomerSearch.ResumeLayout(false);
            this.tabPageCustomerSearch.PerformLayout();
            this.tabPageCustomerAdd.ResumeLayout(false);
            this.tabPageCustomerAdd.PerformLayout();
            this.tabPageCustomerRemove.ResumeLayout(false);
            this.tabPageCustomerRemove.PerformLayout();
            this.tabPageCustomerUpdate.ResumeLayout(false);
            this.tabPageCustomerUpdate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.DataGridView dataGridViewSearchCustomers;
		private System.Windows.Forms.TabControl tabCustomers;
		private System.Windows.Forms.TabPage tabPageCustomerSearch;
		private System.Windows.Forms.TabPage tabPageCustomerAdd;
		private System.Windows.Forms.TabPage tabPageCustomerUpdate;
		private System.Windows.Forms.TabPage tabPageCustomerRemove;
		private System.Windows.Forms.Label labelAddSsn;
		private System.Windows.Forms.Label labelAddName;
		private System.Windows.Forms.Label labelAddPhoneNumber;
		private System.Windows.Forms.Label labelAddAddress;
		private System.Windows.Forms.Button btnAddCustomers;
        private System.Windows.Forms.TextBox textBoxAddPhoneNumber;
        private System.Windows.Forms.TextBox textBoxAddAddress;
        private System.Windows.Forms.TextBox textBoxAddName;
        private System.Windows.Forms.TextBox textBoxAddSsn;
		private System.Windows.Forms.Button btnRemoveCustomers;
		private System.Windows.Forms.ComboBox comboBoxRemoveCustomer;
        private System.Windows.Forms.TextBox textBoxDisplayAddCustomer;
        private System.Windows.Forms.TextBox textBoxDisplayRemoveCustomers;
		private System.Windows.Forms.ComboBox comboBoxUpdateCustomer;
		private System.Windows.Forms.Label labelUpdateSSN;
		private System.Windows.Forms.TextBox textBoxUpdatePhoneNumber;
		private System.Windows.Forms.TextBox textBoxUpdateAddress;
		private System.Windows.Forms.TextBox textBoxUpdateName;
		private System.Windows.Forms.Label labelUpdatePhoneNumber;
		private System.Windows.Forms.Label labelUpdateAddress;
		private System.Windows.Forms.Label labelUpdateName;
		private System.Windows.Forms.TextBox textBoxDisplayUpdateCustomer;
		private System.Windows.Forms.Button UpdateCustomer;
        private System.Windows.Forms.Button btnSwitchToAccountForm;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox comboBoxSearchCustomers;
		private System.Windows.Forms.Label labelSsnSearch;
		private System.Windows.Forms.Button btnGetAllCustomers;
        private System.Windows.Forms.Label labelSSNRemoveCustomer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelSSnFormat;
        private System.Windows.Forms.Label labelNameFormat;
        private System.Windows.Forms.Label labelAddressFormat;
        private System.Windows.Forms.Label labelPhoneNumberFormat;
        private System.Windows.Forms.Label labelUpdatePhoneNumberFormat;
        private System.Windows.Forms.Label labelUpdateAddressFormat;
        private System.Windows.Forms.Label labelUpdateSsnFormat;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelCustomer;
	}
}

