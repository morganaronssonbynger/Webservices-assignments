using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace PA5WS
{
    /// <summary>
    /// Summary description for WebServicePA5
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServicePA5 : System.Web.Services.WebService
    {
        DataAccessLayer dAL = new DataAccessLayer();

		// Webmethod that returns a list of all the employees in the database

        [WebMethod]
        public List<CRONUS_Sverige_AB_Employee> GetEmployees()
        {
            return dAL.GetEmployees();
        }

		// Webmethod that returns a Employee from the database depending on who you search for

		[WebMethod]
		public CRONUS_Sverige_AB_Employee GetEmployee(string no_)
		{
			return dAL.GetEmployee(no_);
		}

		// Webmethod that creates a new employee

		[WebMethod]
		public void CreateEmployee(string firstName, string lastName, string address, string jobTitle)
		{
			dAL.CreateEmployee(firstName, lastName, address, jobTitle);
		}

		// Webmethod that updates an employees information

        [WebMethod]
        public void UpdateEmployee(string no_, string firstName, string lastName, string address, string jobTitle)
        {
			dAL.UpdateEmployee(no_, firstName, lastName, address, jobTitle);
        }

		// Webmethod that removes a specific employee from the database

        [WebMethod]
        public void RemoveEmployee(string no_)
        {
			dAL.RemoveEmployee(no_);
        }
    }
}
