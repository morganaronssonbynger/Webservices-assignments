package pa5;

public class Utility {
	
	// Method for splitting a string
	public static String SplitMethod(String tmp)
	{
		String delim = " - ";
		String[] array = tmp.split(delim);
		return array[0];
	}
}
