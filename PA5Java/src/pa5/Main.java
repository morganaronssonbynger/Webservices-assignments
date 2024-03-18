package pa5;

import pa5.Controller;
import pa5.PA5Frame;

public class Main {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		PA5Frame frame = new PA5Frame(); 
		Controller controller = new Controller(frame); 
		frame.setVisible(true);
	}

}
