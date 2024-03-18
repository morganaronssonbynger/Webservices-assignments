using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PA5WS
{
	public class DataAccessLayer
	{
	
		// Method that returns a list of all the employees in the database

        public List<CRONUS_Sverige_AB_Employee> GetEmployees()
        {
            using (CronusEntities cronusEntities = new CronusEntities())
            {
                List<CRONUS_Sverige_AB_Employee> employees = cronusEntities.CRONUS_Sverige_AB_Employee.ToList();

                return employees;
            }
        }
    
		// Method that returns information about a specific employee from the database

	    public CRONUS_Sverige_AB_Employee GetEmployee(string no_)
	    {
		    using (CronusEntities cronusEntities = new CronusEntities())
		    {
			    CRONUS_Sverige_AB_Employee employee = cronusEntities.CRONUS_Sverige_AB_Employee.Find(no_);
			    return employee;
		    }
	    }

		// Method for removing an employee from the database

        public void RemoveEmployee(string no_)
        {
            using(CronusEntities cronusEntities = new CronusEntities())
            {
                CRONUS_Sverige_AB_Employee employee = this.GetEmployee(no_);

                //The row below is required because we are using our own "get" method, otherwise the connection is lost.
                cronusEntities.CRONUS_Sverige_AB_Employee.Attach(employee);

                cronusEntities.CRONUS_Sverige_AB_Employee.Remove(employee);

                cronusEntities.SaveChanges();
            }
        }

		// Method for updating informaton in the database about a specific employee

        public void UpdateEmployee(string no_, string firstName, string lastName, string address, string jobTitle)
        {
            using (CronusEntities cronusEntities = new CronusEntities())
            {
				CRONUS_Sverige_AB_Employee emp = this.GetEmployee(no_);
				cronusEntities.CRONUS_Sverige_AB_Employee.Attach(emp);

                emp.First_Name = firstName;
				emp.Last_Name = lastName;
				emp.Address = address;
				emp.Job_Title = jobTitle;

				cronusEntities.SaveChanges();
            }
        }

		// Method for creating a new employee

		public void CreateEmployee(string firstName, string lastName, string address, string jobTitle)
		{
			using (CronusEntities cronusEntities = new CronusEntities())
			{
				CRONUS_Sverige_AB_Employee emp = new CRONUS_Sverige_AB_Employee();
         
				emp.No_ = firstName.Substring(0, 1).ToUpper() + lastName.Substring(0, 1).ToUpper();
				emp.First_Name = firstName;
				emp.Last_Name = lastName;
				emp.Address = address;
				emp.Job_Title = jobTitle;
				emp.Grounds_for_Term__Code = "";
				emp.Global_Dimension_1_Code = "";
				emp.Global_Dimension_2_Code = "";
                emp.Inactive_Date = DateTime.Now;
				emp.Initials = "";
				emp.Address_2 = "";
				emp.Alt__Address_Code = "";
				emp.Alt__Address_Start_Date = DateTime.Now;
				emp.Alt__Address_End_Date = DateTime.Now;
				emp.Birth_Date = DateTime.Now;
				emp.Cause_of_Inactivity_Code = "";
				emp.City = "Malmö";
				emp.Company_E_Mail = "";
				emp.Country_Region_Code = "";
				emp.County = "";
				emp.Employment_Date = DateTime.Now;
				emp.Emplymt__Contract_Code = "";
				emp.Extension = "";
				emp.E_Mail = "";
				emp.Fax_No_ = "";
				emp.Last_Date_Modified = DateTime.Now;
				emp.Manager_No_ = "";
				emp.Middle_Name = "";
				emp.Mobile_Phone_No_ = "";
				emp.No__Series = "";
				emp.Pager = "";
				emp.Phone_No_ = "";
				emp.Post_Code = "";
				emp.Resource_No_ = "";
				emp.Salespers__Purch__Code = "";
				emp.Search_Name = "";
				emp.Sex = 1;
				emp.Social_Security_No_ = "";
				emp.Statistics_Group_Code = "";
				emp.Status = 1;
				emp.Termination_Date = DateTime.Now;
				emp.timestamp = new byte[1];
				emp.Title = "";
				emp.Union_Code = "";
				emp.Union_Membership_No_ = "";

				cronusEntities.CRONUS_Sverige_AB_Employee.Add(emp);
                cronusEntities.SaveChanges();
			}
		}
	}
}