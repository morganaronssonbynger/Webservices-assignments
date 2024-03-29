﻿using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

namespace PA3A
{
	//------------------------------------------------------------------------------
	// <auto-generated>
	//     This code was generated by a tool.
	//     Runtime Version:4.0.30319.42000
	//
	//     Changes to this file may cause incorrect behavior and will be lost if
	//     the code is regenerated.
	// </auto-generated>
	//------------------------------------------------------------------------------

	using System;
	using System.ComponentModel;
	using System.Diagnostics;
	using System.Web.Services;
	using System.Web.Services.Protocols;
	using System.Xml.Serialization;

	// 
	// This source code was auto-generated by wsdl, Version=4.6.1055.0.
	// 


	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Web.Services.WebServiceBindingAttribute(Name = "WebServicePA3Soap", Namespace = "http://tempuri.org/")]
	public partial class WebServicePA3 : System.Web.Services.Protocols.SoapHttpClientProtocol
	{

		private System.Threading.SendOrPostCallback KritaOperationCompleted;

		private System.Threading.SendOrPostCallback GetFileOperationCompleted;

		/// <remarks/>
		public WebServicePA3()
		{
			this.Url = "http://localhost/PA3WS/WebServicePA3.asmx";
		}

		/// <remarks/>
		public event KritaCompletedEventHandler KritaCompleted;

		/// <remarks/>
		public event GetFileCompletedEventHandler GetFileCompleted;

		/// <remarks/>
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Krita", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public string Krita()
		{
			object[] results = this.Invoke("Krita", new object[0]);
			return ((string)(results[0]));
		}

		/// <remarks/>
		public System.IAsyncResult BeginKrita(System.AsyncCallback callback, object asyncState)
		{
			return this.BeginInvoke("Krita", new object[0], callback, asyncState);
		}

		/// <remarks/>
		public string EndKrita(System.IAsyncResult asyncResult)
		{
			object[] results = this.EndInvoke(asyncResult);
			return ((string)(results[0]));
		}

		/// <remarks/>
		public void KritaAsync()
		{
			this.KritaAsync(null);
		}

		/// <remarks/>
		public void KritaAsync(object userState)
		{
			if ((this.KritaOperationCompleted == null))
			{
				this.KritaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnKritaOperationCompleted);
			}
			this.InvokeAsync("Krita", new object[0], this.KritaOperationCompleted, userState);
		}

		private void OnKritaOperationCompleted(object arg)
		{
			if ((this.KritaCompleted != null))
			{
				System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
				this.KritaCompleted(this, new KritaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
			}
		}

		/// <remarks/>
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetFile", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public string GetFile(string fileName)
		{
			object[] results = this.Invoke("GetFile", new object[] {
					fileName});
			return ((string)(results[0]));
		}

		/// <remarks/>
		public System.IAsyncResult BeginGetFile(string fileName, System.AsyncCallback callback, object asyncState)
		{
			return this.BeginInvoke("GetFile", new object[] {
					fileName}, callback, asyncState);
		}

		/// <remarks/>
		public string EndGetFile(System.IAsyncResult asyncResult)
		{
			object[] results = this.EndInvoke(asyncResult);
			return ((string)(results[0]));
		}

		/// <remarks/>
		public void GetFileAsync(string fileName)
		{
			this.GetFileAsync(fileName, null);
		}

		/// <remarks/>
		public void GetFileAsync(string fileName, object userState)
		{
			if ((this.GetFileOperationCompleted == null))
			{
				this.GetFileOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetFileOperationCompleted);
			}
			this.InvokeAsync("GetFile", new object[] {
					fileName}, this.GetFileOperationCompleted, userState);
		}

		private void OnGetFileOperationCompleted(object arg)
		{
			if ((this.GetFileCompleted != null))
			{
				System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
				this.GetFileCompleted(this, new GetFileCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
			}
		}

		/// <remarks/>
		public new void CancelAsync(object userState)
		{
			base.CancelAsync(userState);
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
	public delegate void KritaCompletedEventHandler(object sender, KritaCompletedEventArgs e);

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class KritaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
	{

		private object[] results;

		internal KritaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
				base(exception, cancelled, userState)
		{
			this.results = results;
		}

		/// <remarks/>
		public string Result
		{
			get
			{
				this.RaiseExceptionIfNecessary();
				return ((string)(this.results[0]));
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
	public delegate void GetFileCompletedEventHandler(object sender, GetFileCompletedEventArgs e);

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class GetFileCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
	{

		private object[] results;

		internal GetFileCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
				base(exception, cancelled, userState)
		{
			this.results = results;
		}

		/// <remarks/>
		public string Result
		{
			get
			{
				this.RaiseExceptionIfNecessary();
				return ((string)(this.results[0]));
			}
		}
	}

}
