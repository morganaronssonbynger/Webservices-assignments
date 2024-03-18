package pa6;

import java.rmi.RemoteException;

import org.tempuri.WebServicePA6Soap;
import org.tempuri.WebServicePA6SoapProxy;

import pa6.Controller;
import pa6.PA6Frame;

public class MainPA6 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		PA6Frame frame = new PA6Frame(); 
		Controller controller = new Controller(frame); 
		frame.setVisible(true);

	}

}
