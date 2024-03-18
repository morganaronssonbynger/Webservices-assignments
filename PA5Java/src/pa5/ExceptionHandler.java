package pa5;

public class ExceptionHandler {
	
	// Method for handling exceptions 	
	public String HandleException(Exception ex) {
		
		if(ex instanceof NullPointerException){
			return "There were problems connecting to the server" + "\n please check your internet connection and/or " + "\n contacting IT support at: 0730880819"; 
		}
		// Error message for primary key violation
		else if(ex.getMessage().contains("Violation of PRIMARY KEY"))
        {
            return "A person with these initials" + "\nalready exist please try another one.";
        }
		// Error message for connection 
		else if (ex.getMessage().contains("error: 40 "))
		{
			return "Check your internet connection" +  "\nor contact our IT support at: 0730880819";
		}
		// Error message for failing to access database 
		else if (ex.getMessage().contains("Cannot open database"))
		{
			return "Connection failed to the database," + "\nplease check if the name is spelled correctly" +"\nfor the database or if the username" +"\nand/or password is correct," + "\nor if the user has access to the database";
		}
		// Error message for server connection
		else if (ex.getMessage().contains("error: 26"))
		{
			return "Connection failed to the server please" + "\n check if you are connected to the server.";
		}
		else if (ex.getMessage().contains("System.Data.Entity.Validation.DbEntityValidationException")) {
			return "The amount of characters exceeds the database limit, \n the maximum amount of characters is 30 for first name, \n last name and job title, and 50 for address";
		}
		// Error message for unexpected error
		else
        {
            return "Unknown error contact our IT support at: 0730880819";
        }
	}

}
