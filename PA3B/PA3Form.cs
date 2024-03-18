﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA3B
{
    public partial class PA3Form : Form
    {

		// Using wsdl.exe autogenerated proxy

		WebServicePA3 proxy = new WebServicePA3();

		// Default constructor for the PA3Form

		public PA3Form()
        {
            InitializeComponent();
        }

		// Method for getting the contents of a file with a filepath

		private void BtnSearch_Click(object sender, EventArgs e)
		{
			try
			{
				string filePath = textBoxFilePath.Text;
				string fileText = proxy.GetFile(filePath);
				textBoxDisplay.Text = fileText;
			}
			catch(Exception ex)
			{
				string errorMessage = ExceptionHandler.HandleException(ex);
				textBoxDisplay.Text = errorMessage;
			}	
		}
	}
}