package pa3;

public class ExceptionHandler {
	
	// Method for handling exceptions
	public static String handleException(Exception ex) {
		
		// Error message if text field is empty
		if (ex.toString().contains("ArgumentException")) {
			return "Please enter a file path";
		}
		
		// Error message if file cannot be found
		else if (ex.toString().contains("System.IO.FileNotFoundException")) {
			return "Could not find a file with that file path, please try another.";
		}
		
		// Error message if the file is restricted 
		else if (ex.toString().contains("System.UnauthorizedAccessException")) {
			return "You are not authorized to view the content of this file";
		}
		// Error message for unexpected error
		else {		
			return "Please contact the IT-department at: 0730880819";
		}
	}
}
