package pa3;

import java.rmi.RemoteException;

import org.tempuri.WebServicePA3Soap;
import org.tempuri.WebServicePA3SoapProxy;

public class Main {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
	

		
		PA3Frame frame = new PA3Frame();
		Controller controller = new Controller(frame); 
		frame.setVisible(true); 

	}

}
