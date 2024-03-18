namespace PA2
{
	partial class PA2Form
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
            this.dataGridViewMetaData = new System.Windows.Forms.DataGridView();
            this.btnGetAllColumns = new System.Windows.Forms.Button();
            this.btnGetNrOfRows = new System.Windows.Forms.Button();
            this.labelTablesOfInterest = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMetaData)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMetaData
            // 
            this.dataGridViewMetaData.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewMetaData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMetaData.Location = new System.Drawing.Point(243, 178);
            this.dataGridViewMetaData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewMetaData.Name = "dataGridViewMetaData";
            this.dataGridViewMetaData.Size = new System.Drawing.Size(575, 292);
            this.dataGridViewMetaData.TabIndex = 0;
            // 
            // btnGetAllColumns
            // 
            this.btnGetAllColumns.Location = new System.Drawing.Point(583, 126);
            this.btnGetAllColumns.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGetAllColumns.Name = "btnGetAllColumns";
            this.btnGetAllColumns.Size = new System.Drawing.Size(136, 28);
            this.btnGetAllColumns.TabIndex = 2;
            this.btnGetAllColumns.Text = "Get all columns";
            this.btnGetAllColumns.UseVisualStyleBackColor = true;
            this.btnGetAllColumns.Click += new System.EventHandler(this.BtnGetAllColumns_Click);
            // 
            // btnGetNrOfRows
            // 
            this.btnGetNrOfRows.Location = new System.Drawing.Point(339, 126);
            this.btnGetNrOfRows.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGetNrOfRows.Name = "btnGetNrOfRows";
            this.btnGetNrOfRows.Size = new System.Drawing.Size(161, 28);
            this.btnGetNrOfRows.TabIndex = 3;
            this.btnGetNrOfRows.Text = "Get number of rows";
            this.btnGetNrOfRows.UseVisualStyleBackColor = true;
            this.btnGetNrOfRows.Click += new System.EventHandler(this.BtnGetNrOfRows_Click);
            // 
            // labelTablesOfInterest
            // 
            this.labelTablesOfInterest.AutoSize = true;
            this.labelTablesOfInterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTablesOfInterest.Location = new System.Drawing.Point(403, 41);
            this.labelTablesOfInterest.Name = "labelTablesOfInterest";
            this.labelTablesOfInterest.Size = new System.Drawing.Size(233, 32);
            this.labelTablesOfInterest.TabIndex = 5;
            this.labelTablesOfInterest.Text = "Tables of interest";
            // 
            // PA2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.labelTablesOfInterest);
            this.Controls.Add(this.btnGetNrOfRows);
            this.Controls.Add(this.btnGetAllColumns);
            this.Controls.Add(this.dataGridViewMetaData);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PA2Form";
            this.Text = "PA2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMetaData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridViewMetaData;
		private System.Windows.Forms.Button btnGetAllColumns;
		private System.Windows.Forms.Button btnGetNrOfRows;
        private System.Windows.Forms.Label labelTablesOfInterest;
    }
}

