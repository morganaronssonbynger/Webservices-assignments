package pa3;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.rmi.RemoteException;

import org.tempuri.WebServicePA3Soap;
import org.tempuri.WebServicePA3SoapProxy;

public class Controller {
	
	private PA3Frame frame;
	private WebServicePA3Soap proxy; 
	private ExceptionHandler eH = new ExceptionHandler(); 
	
	 
	// Controller constructor 
	public Controller (PA3Frame frame) {
		this.frame = frame;
		proxy = new WebServicePA3SoapProxy();
		initialize(); 
	}
	
	// Method to access file 
	private void initialize() {
		frame.getBtnSearch().addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				String filePath = frame.getTextFieldFilePath().getText();
				
				try {
					String textFile = proxy.getFile(filePath);
					frame.getTextAreaFilePath().setText(textFile);
				} catch (Exception ex) {					
					String errorMessage = eH.handleException(ex);
					frame.getTextAreaFilePath().setText(errorMessage);
				}
			}
		});
		
	}

}
