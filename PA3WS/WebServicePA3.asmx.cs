using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace PA3WS
{
    /// <summary>
    /// Summary description for WebServicePA3
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServicePA3 : System.Web.Services.WebService
    {
		// Webmethod that returns the contents of a file when searching on a filepath
		//https://docs.microsoft.com/en-us/troubleshoot/dotnet/csharp/read-write-text-file

		[WebMethod]
        public string GetFile(string fileName)
		{ 
			StreamReader streamReader = File.OpenText(fileName);
            {
                string text = streamReader.ReadToEnd();
				return text;
            }
        }
    }
}
