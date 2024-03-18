namespace PA6WF
{
	partial class PA6Form
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
            this.dataGridViewDataDisplayer = new System.Windows.Forms.DataGridView();
            this.comboBoxOptions = new System.Windows.Forms.ComboBox();
            this.labelOptions = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataDisplayer)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDataDisplayer
            // 
            this.dataGridViewDataDisplayer.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewDataDisplayer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDataDisplayer.Location = new System.Drawing.Point(43, 123);
            this.dataGridViewDataDisplayer.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewDataDisplayer.Name = "dataGridViewDataDisplayer";
            this.dataGridViewDataDisplayer.Size = new System.Drawing.Size(968, 405);
            this.dataGridViewDataDisplayer.TabIndex = 1;
            // 
            // comboBoxOptions
            // 
            this.comboBoxOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOptions.FormattingEnabled = true;
            this.comboBoxOptions.Location = new System.Drawing.Point(344, 70);
            this.comboBoxOptions.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxOptions.Name = "comboBoxOptions";
            this.comboBoxOptions.Size = new System.Drawing.Size(349, 24);
            this.comboBoxOptions.TabIndex = 9;
            this.comboBoxOptions.SelectedIndexChanged += new System.EventHandler(this.ComboBoxOptions_SelectedIndexChanged);
            // 
            // labelOptions
            // 
            this.labelOptions.AutoSize = true;
            this.labelOptions.Location = new System.Drawing.Point(256, 73);
            this.labelOptions.Name = "labelOptions";
            this.labelOptions.Size = new System.Drawing.Size(61, 17);
            this.labelOptions.TabIndex = 10;
            this.labelOptions.Text = "Options:";
            // 
            // PA6Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.labelOptions);
            this.Controls.Add(this.comboBoxOptions);
            this.Controls.Add(this.dataGridViewDataDisplayer);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PA6Form";
            this.Text = "PA6";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataDisplayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.DataGridView dataGridViewDataDisplayer;
		private System.Windows.Forms.ComboBox comboBoxOptions;
        private System.Windows.Forms.Label labelOptions;
    }
}

