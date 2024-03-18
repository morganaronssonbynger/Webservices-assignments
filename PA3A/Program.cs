using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA3A
{
    class Program
    {
        static void Main(string[] args)
        {
			try
			{
				// Using wsdl.exe proxy with command prompt

				WebServicePA3 proxy = new WebServicePA3();

				string fileText = proxy.GetFile(@"C:\Users\Administrator\Documents\PA3file.txt");

				Console.WriteLine(fileText);
				Console.Read();
			}
			catch(Exception ex)
			{
				string errorMessage = ExceptionHandler.HandleException(ex);
				Console.WriteLine(errorMessage);
				Console.Read();
			}

        }
    }
}
