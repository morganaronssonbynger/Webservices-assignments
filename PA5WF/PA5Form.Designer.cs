namespace PA5WF
{
    partial class PA5Form
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
            this.btnGetEmployees = new System.Windows.Forms.Button();
            this.dataGridViewSearchEmployee = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textBoxFirstNameAdd = new System.Windows.Forms.TextBox();
            this.textBoxLastNameAdd = new System.Windows.Forms.TextBox();
            this.textBoxAddressAdd = new System.Windows.Forms.TextBox();
            this.textBoxJobTitleAdd = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageGetEmployee = new System.Windows.Forms.TabPage();
            this.comboBox_GetEmployee = new System.Windows.Forms.ComboBox();
            this.labelNo_ = new System.Windows.Forms.Label();
            this.tabPageAddEmployee = new System.Windows.Forms.TabPage();
            this.labelJobTitle = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxDisplayAddEmployee = new System.Windows.Forms.TextBox();
            this.tabPageUpdateEmployee = new System.Windows.Forms.TabPage();
            this.comboBox_updateEmployee = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.labelNoUpdate = new System.Windows.Forms.Label();
            this.labelJobTitleUpdate = new System.Windows.Forms.Label();
            this.labelAddressUpdate = new System.Windows.Forms.Label();
            this.labelLastNameUpdate = new System.Windows.Forms.Label();
            this.labelFirstNameUpdate = new System.Windows.Forms.Label();
            this.textBoxDisplayUpdate = new System.Windows.Forms.TextBox();
            this.textBoxJobTitleUpdate = new System.Windows.Forms.TextBox();
            this.textBoxAddressUpdate = new System.Windows.Forms.TextBox();
            this.textBoxLastNameUpdate = new System.Windows.Forms.TextBox();
            this.textBoxFirstNameUpdate = new System.Windows.Forms.TextBox();
            this.tabPageRemoveEmployee = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_removeEmployee = new System.Windows.Forms.ComboBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.textBoxDisplayRemoveEmployee = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.labelEmployee = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchEmployee)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageGetEmployee.SuspendLayout();
            this.tabPageAddEmployee.SuspendLayout();
            this.tabPageUpdateEmployee.SuspendLayout();
            this.tabPageRemoveEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetEmployees
            // 
            this.btnGetEmployees.Location = new System.Drawing.Point(118, 386);
            this.btnGetEmployees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGetEmployees.Name = "btnGetEmployees";
            this.btnGetEmployees.Size = new System.Drawing.Size(172, 28);
            this.btnGetEmployees.TabIndex = 0;
            this.btnGetEmployees.Text = "Get all employees";
            this.btnGetEmployees.UseVisualStyleBackColor = true;
            this.btnGetEmployees.Click += new System.EventHandler(this.BtnGetEmployees_Click);
            // 
            // dataGridViewSearchEmployee
            // 
            this.dataGridViewSearchEmployee.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewSearchEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearchEmployee.Location = new System.Drawing.Point(333, 87);
            this.dataGridViewSearchEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewSearchEmployee.Name = "dataGridViewSearchEmployee";
            this.dataGridViewSearchEmployee.RowTemplate.Height = 24;
            this.dataGridViewSearchEmployee.Size = new System.Drawing.Size(700, 327);
            this.dataGridViewSearchEmployee.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(118, 163);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(172, 28);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // textBoxFirstNameAdd
            // 
            this.textBoxFirstNameAdd.Location = new System.Drawing.Point(118, 87);
            this.textBoxFirstNameAdd.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFirstNameAdd.Name = "textBoxFirstNameAdd";
            this.textBoxFirstNameAdd.Size = new System.Drawing.Size(165, 22);
            this.textBoxFirstNameAdd.TabIndex = 4;
            // 
            // textBoxLastNameAdd
            // 
            this.textBoxLastNameAdd.Location = new System.Drawing.Point(118, 136);
            this.textBoxLastNameAdd.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLastNameAdd.Name = "textBoxLastNameAdd";
            this.textBoxLastNameAdd.Size = new System.Drawing.Size(165, 22);
            this.textBoxLastNameAdd.TabIndex = 5;
            // 
            // textBoxAddressAdd
            // 
            this.textBoxAddressAdd.Location = new System.Drawing.Point(118, 186);
            this.textBoxAddressAdd.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAddressAdd.Name = "textBoxAddressAdd";
            this.textBoxAddressAdd.Size = new System.Drawing.Size(165, 22);
            this.textBoxAddressAdd.TabIndex = 6;
            // 
            // textBoxJobTitleAdd
            // 
            this.textBoxJobTitleAdd.Location = new System.Drawing.Point(118, 234);
            this.textBoxJobTitleAdd.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxJobTitleAdd.Name = "textBoxJobTitleAdd";
            this.textBoxJobTitleAdd.Size = new System.Drawing.Size(165, 22);
            this.textBoxJobTitleAdd.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(142, 317);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageGetEmployee);
            this.tabControl1.Controls.Add(this.tabPageAddEmployee);
            this.tabControl1.Controls.Add(this.tabPageUpdateEmployee);
            this.tabControl1.Controls.Add(this.tabPageRemoveEmployee);
            this.tabControl1.Location = new System.Drawing.Point(12, 58);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1047, 555);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPageGetEmployee
            // 
            this.tabPageGetEmployee.Controls.Add(this.comboBox_GetEmployee);
            this.tabPageGetEmployee.Controls.Add(this.labelNo_);
            this.tabPageGetEmployee.Controls.Add(this.dataGridViewSearchEmployee);
            this.tabPageGetEmployee.Controls.Add(this.btnGetEmployees);
            this.tabPageGetEmployee.Controls.Add(this.btnSearch);
            this.tabPageGetEmployee.Location = new System.Drawing.Point(4, 25);
            this.tabPageGetEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageGetEmployee.Name = "tabPageGetEmployee";
            this.tabPageGetEmployee.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageGetEmployee.Size = new System.Drawing.Size(1039, 526);
            this.tabPageGetEmployee.TabIndex = 0;
            this.tabPageGetEmployee.Text = "Get Employee";
            this.tabPageGetEmployee.UseVisualStyleBackColor = true;
            // 
            // comboBox_GetEmployee
            // 
            this.comboBox_GetEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_GetEmployee.FormattingEnabled = true;
            this.comboBox_GetEmployee.Location = new System.Drawing.Point(118, 87);
            this.comboBox_GetEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_GetEmployee.Name = "comboBox_GetEmployee";
            this.comboBox_GetEmployee.Size = new System.Drawing.Size(172, 24);
            this.comboBox_GetEmployee.TabIndex = 5;
            // 
            // labelNo_
            // 
            this.labelNo_.AutoSize = true;
            this.labelNo_.Location = new System.Drawing.Point(52, 90);
            this.labelNo_.Name = "labelNo_";
            this.labelNo_.Size = new System.Drawing.Size(38, 17);
            this.labelNo_.TabIndex = 4;
            this.labelNo_.Text = "No_:";
            // 
            // tabPageAddEmployee
            // 
            this.tabPageAddEmployee.Controls.Add(this.labelJobTitle);
            this.tabPageAddEmployee.Controls.Add(this.labelAddress);
            this.tabPageAddEmployee.Controls.Add(this.labelLastName);
            this.tabPageAddEmployee.Controls.Add(this.labelFirstName);
            this.tabPageAddEmployee.Controls.Add(this.textBoxDisplayAddEmployee);
            this.tabPageAddEmployee.Controls.Add(this.textBoxFirstNameAdd);
            this.tabPageAddEmployee.Controls.Add(this.btnAdd);
            this.tabPageAddEmployee.Controls.Add(this.textBoxLastNameAdd);
            this.tabPageAddEmployee.Controls.Add(this.textBoxJobTitleAdd);
            this.tabPageAddEmployee.Controls.Add(this.textBoxAddressAdd);
            this.tabPageAddEmployee.Location = new System.Drawing.Point(4, 25);
            this.tabPageAddEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageAddEmployee.Name = "tabPageAddEmployee";
            this.tabPageAddEmployee.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageAddEmployee.Size = new System.Drawing.Size(1039, 526);
            this.tabPageAddEmployee.TabIndex = 1;
            this.tabPageAddEmployee.Text = "Add Employee";
            this.tabPageAddEmployee.UseVisualStyleBackColor = true;
            // 
            // labelJobTitle
            // 
            this.labelJobTitle.AutoSize = true;
            this.labelJobTitle.Location = new System.Drawing.Point(26, 234);
            this.labelJobTitle.Name = "labelJobTitle";
            this.labelJobTitle.Size = new System.Drawing.Size(71, 17);
            this.labelJobTitle.TabIndex = 13;
            this.labelJobTitle.Text = "Job Title:*";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(26, 186);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(69, 17);
            this.labelAddress.TabIndex = 12;
            this.labelAddress.Text = "Address:*";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(26, 136);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(85, 17);
            this.labelLastName.TabIndex = 11;
            this.labelLastName.Text = "Last Name:*";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(26, 87);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(85, 17);
            this.labelFirstName.TabIndex = 10;
            this.labelFirstName.Text = "First Name:*";
            // 
            // textBoxDisplayAddEmployee
            // 
            this.textBoxDisplayAddEmployee.Location = new System.Drawing.Point(339, 84);
            this.textBoxDisplayAddEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDisplayAddEmployee.Multiline = true;
            this.textBoxDisplayAddEmployee.Name = "textBoxDisplayAddEmployee";
            this.textBoxDisplayAddEmployee.Size = new System.Drawing.Size(457, 261);
            this.textBoxDisplayAddEmployee.TabIndex = 9;
            // 
            // tabPageUpdateEmployee
            // 
            this.tabPageUpdateEmployee.Controls.Add(this.comboBox_updateEmployee);
            this.tabPageUpdateEmployee.Controls.Add(this.btnUpdate);
            this.tabPageUpdateEmployee.Controls.Add(this.labelNoUpdate);
            this.tabPageUpdateEmployee.Controls.Add(this.labelJobTitleUpdate);
            this.tabPageUpdateEmployee.Controls.Add(this.labelAddressUpdate);
            this.tabPageUpdateEmployee.Controls.Add(this.labelLastNameUpdate);
            this.tabPageUpdateEmployee.Controls.Add(this.labelFirstNameUpdate);
            this.tabPageUpdateEmployee.Controls.Add(this.textBoxDisplayUpdate);
            this.tabPageUpdateEmployee.Controls.Add(this.textBoxJobTitleUpdate);
            this.tabPageUpdateEmployee.Controls.Add(this.textBoxAddressUpdate);
            this.tabPageUpdateEmployee.Controls.Add(this.textBoxLastNameUpdate);
            this.tabPageUpdateEmployee.Controls.Add(this.textBoxFirstNameUpdate);
            this.tabPageUpdateEmployee.Location = new System.Drawing.Point(4, 25);
            this.tabPageUpdateEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageUpdateEmployee.Name = "tabPageUpdateEmployee";
            this.tabPageUpdateEmployee.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageUpdateEmployee.Size = new System.Drawing.Size(1039, 526);
            this.tabPageUpdateEmployee.TabIndex = 2;
            this.tabPageUpdateEmployee.Text = "Update Employee";
            this.tabPageUpdateEmployee.UseVisualStyleBackColor = true;
            // 
            // comboBox_updateEmployee
            // 
            this.comboBox_updateEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_updateEmployee.FormattingEnabled = true;
            this.comboBox_updateEmployee.Location = new System.Drawing.Point(118, 87);
            this.comboBox_updateEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_updateEmployee.Name = "comboBox_updateEmployee";
            this.comboBox_updateEmployee.Size = new System.Drawing.Size(165, 24);
            this.comboBox_updateEmployee.TabIndex = 18;
            this.comboBox_updateEmployee.SelectedIndexChanged += new System.EventHandler(this.ComboBox_updateEmployee_SelectedIndexChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(129, 319);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(138, 26);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // labelNoUpdate
            // 
            this.labelNoUpdate.AutoSize = true;
            this.labelNoUpdate.Location = new System.Drawing.Point(26, 87);
            this.labelNoUpdate.Name = "labelNoUpdate";
            this.labelNoUpdate.Size = new System.Drawing.Size(43, 17);
            this.labelNoUpdate.TabIndex = 16;
            this.labelNoUpdate.Text = "No_:*";
            // 
            // labelJobTitleUpdate
            // 
            this.labelJobTitleUpdate.AutoSize = true;
            this.labelJobTitleUpdate.Location = new System.Drawing.Point(26, 278);
            this.labelJobTitleUpdate.Name = "labelJobTitleUpdate";
            this.labelJobTitleUpdate.Size = new System.Drawing.Size(71, 17);
            this.labelJobTitleUpdate.TabIndex = 14;
            this.labelJobTitleUpdate.Text = "Job Title:*";
            // 
            // labelAddressUpdate
            // 
            this.labelAddressUpdate.AutoSize = true;
            this.labelAddressUpdate.Location = new System.Drawing.Point(26, 234);
            this.labelAddressUpdate.Name = "labelAddressUpdate";
            this.labelAddressUpdate.Size = new System.Drawing.Size(69, 17);
            this.labelAddressUpdate.TabIndex = 13;
            this.labelAddressUpdate.Text = "Address:*";
            // 
            // labelLastNameUpdate
            // 
            this.labelLastNameUpdate.AutoSize = true;
            this.labelLastNameUpdate.Location = new System.Drawing.Point(26, 186);
            this.labelLastNameUpdate.Name = "labelLastNameUpdate";
            this.labelLastNameUpdate.Size = new System.Drawing.Size(85, 17);
            this.labelLastNameUpdate.TabIndex = 12;
            this.labelLastNameUpdate.Text = "Last Name:*";
            // 
            // labelFirstNameUpdate
            // 
            this.labelFirstNameUpdate.AutoSize = true;
            this.labelFirstNameUpdate.Location = new System.Drawing.Point(26, 136);
            this.labelFirstNameUpdate.Name = "labelFirstNameUpdate";
            this.labelFirstNameUpdate.Size = new System.Drawing.Size(85, 17);
            this.labelFirstNameUpdate.TabIndex = 11;
            this.labelFirstNameUpdate.Text = "First Name:*";
            // 
            // textBoxDisplayUpdate
            // 
            this.textBoxDisplayUpdate.Location = new System.Drawing.Point(339, 84);
            this.textBoxDisplayUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDisplayUpdate.Multiline = true;
            this.textBoxDisplayUpdate.Name = "textBoxDisplayUpdate";
            this.textBoxDisplayUpdate.Size = new System.Drawing.Size(457, 261);
            this.textBoxDisplayUpdate.TabIndex = 9;
            // 
            // textBoxJobTitleUpdate
            // 
            this.textBoxJobTitleUpdate.Location = new System.Drawing.Point(118, 278);
            this.textBoxJobTitleUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxJobTitleUpdate.Name = "textBoxJobTitleUpdate";
            this.textBoxJobTitleUpdate.Size = new System.Drawing.Size(165, 22);
            this.textBoxJobTitleUpdate.TabIndex = 8;
            // 
            // textBoxAddressUpdate
            // 
            this.textBoxAddressUpdate.Location = new System.Drawing.Point(118, 234);
            this.textBoxAddressUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAddressUpdate.Name = "textBoxAddressUpdate";
            this.textBoxAddressUpdate.Size = new System.Drawing.Size(165, 22);
            this.textBoxAddressUpdate.TabIndex = 7;
            // 
            // textBoxLastNameUpdate
            // 
            this.textBoxLastNameUpdate.Location = new System.Drawing.Point(118, 186);
            this.textBoxLastNameUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLastNameUpdate.Name = "textBoxLastNameUpdate";
            this.textBoxLastNameUpdate.Size = new System.Drawing.Size(165, 22);
            this.textBoxLastNameUpdate.TabIndex = 6;
            // 
            // textBoxFirstNameUpdate
            // 
            this.textBoxFirstNameUpdate.Location = new System.Drawing.Point(118, 136);
            this.textBoxFirstNameUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFirstNameUpdate.Name = "textBoxFirstNameUpdate";
            this.textBoxFirstNameUpdate.Size = new System.Drawing.Size(165, 22);
            this.textBoxFirstNameUpdate.TabIndex = 5;
            // 
            // tabPageRemoveEmployee
            // 
            this.tabPageRemoveEmployee.Controls.Add(this.label1);
            this.tabPageRemoveEmployee.Controls.Add(this.comboBox_removeEmployee);
            this.tabPageRemoveEmployee.Controls.Add(this.btnRemove);
            this.tabPageRemoveEmployee.Controls.Add(this.textBoxDisplayRemoveEmployee);
            this.tabPageRemoveEmployee.Location = new System.Drawing.Point(4, 25);
            this.tabPageRemoveEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageRemoveEmployee.Name = "tabPageRemoveEmployee";
            this.tabPageRemoveEmployee.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageRemoveEmployee.Size = new System.Drawing.Size(1039, 526);
            this.tabPageRemoveEmployee.TabIndex = 3;
            this.tabPageRemoveEmployee.Text = "Remove Employee";
            this.tabPageRemoveEmployee.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "No_:";
            // 
            // comboBox_removeEmployee
            // 
            this.comboBox_removeEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_removeEmployee.FormattingEnabled = true;
            this.comboBox_removeEmployee.Location = new System.Drawing.Point(118, 87);
            this.comboBox_removeEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_removeEmployee.Name = "comboBox_removeEmployee";
            this.comboBox_removeEmployee.Size = new System.Drawing.Size(165, 24);
            this.comboBox_removeEmployee.TabIndex = 3;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(148, 183);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(100, 23);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // textBoxDisplayRemoveEmployee
            // 
            this.textBoxDisplayRemoveEmployee.Location = new System.Drawing.Point(339, 84);
            this.textBoxDisplayRemoveEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDisplayRemoveEmployee.Multiline = true;
            this.textBoxDisplayRemoveEmployee.Name = "textBoxDisplayRemoveEmployee";
            this.textBoxDisplayRemoveEmployee.Size = new System.Drawing.Size(457, 261);
            this.textBoxDisplayRemoveEmployee.TabIndex = 1;
            // 
            // labelEmployee
            // 
            this.labelEmployee.AutoSize = true;
            this.labelEmployee.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployee.Location = new System.Drawing.Point(477, 9);
            this.labelEmployee.Name = "labelEmployee";
            this.labelEmployee.Size = new System.Drawing.Size(136, 31);
            this.labelEmployee.TabIndex = 10;
            this.labelEmployee.Text = "Employee";
            // 
            // PA5Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 624);
            this.Controls.Add(this.labelEmployee);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PA5Form";
            this.Text = "PA5";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchEmployee)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageGetEmployee.ResumeLayout(false);
            this.tabPageGetEmployee.PerformLayout();
            this.tabPageAddEmployee.ResumeLayout(false);
            this.tabPageAddEmployee.PerformLayout();
            this.tabPageUpdateEmployee.ResumeLayout(false);
            this.tabPageUpdateEmployee.PerformLayout();
            this.tabPageRemoveEmployee.ResumeLayout(false);
            this.tabPageRemoveEmployee.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetEmployees;
        private System.Windows.Forms.DataGridView dataGridViewSearchEmployee;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.TextBox textBoxFirstNameAdd;
		private System.Windows.Forms.TextBox textBoxLastNameAdd;
		private System.Windows.Forms.TextBox textBoxAddressAdd;
		private System.Windows.Forms.TextBox textBoxJobTitleAdd;
		private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageGetEmployee;
        private System.Windows.Forms.TabPage tabPageAddEmployee;
        private System.Windows.Forms.TabPage tabPageUpdateEmployee;
        private System.Windows.Forms.TabPage tabPageRemoveEmployee;
        private System.Windows.Forms.TextBox textBoxDisplayRemoveEmployee;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox textBoxDisplayAddEmployee;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelJobTitle;
        private System.Windows.Forms.Label labelNo_;
        private System.Windows.Forms.TextBox textBoxFirstNameUpdate;
        private System.Windows.Forms.TextBox textBoxJobTitleUpdate;
        private System.Windows.Forms.TextBox textBoxAddressUpdate;
        private System.Windows.Forms.TextBox textBoxLastNameUpdate;
        private System.Windows.Forms.TextBox textBoxDisplayUpdate;
        private System.Windows.Forms.Label labelFirstNameUpdate;
        private System.Windows.Forms.Label labelJobTitleUpdate;
        private System.Windows.Forms.Label labelAddressUpdate;
        private System.Windows.Forms.Label labelLastNameUpdate;
        private System.Windows.Forms.Label labelNoUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox comboBox_GetEmployee;
		private System.Windows.Forms.ComboBox comboBox_updateEmployee;
		private System.Windows.Forms.ComboBox comboBox_removeEmployee;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label labelEmployee;
    }
}

