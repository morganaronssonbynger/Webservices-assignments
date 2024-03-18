package pa6;

public class ExceptionHandler {
	
	// Method for handling exceptions
	public String HandleException(Exception ex) {
		
		// Error message for connection
		if (ex.getMessage().contains("error: 40 "))
		{
			return "Check your internet connection" +  "\n or contact our IT support at: 0730880819";
		}
		// Error message for failing to access database
		else if (ex.getMessage().contains("Cannot open database"))
		{
			return "Connection failed to the database," + "\n please check if the name is spelled correctly" +"\n for the database or if the username" +"\n and/or password is correct," + "\n or if the user has access to the database";
		}
		// Error message for server connection
		else if (ex.getMessage().contains("error: 26"))
		{
			return "Connection failed to the server please" + "\n check if you are connected to the server.";
		}
		// Error message for unexpected error
		else
        {
            return "Unknown error contact our IT support at: 0730880819";
        }
	}
}
